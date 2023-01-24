using Mtconnect;
using Mtconnect.AdapterInterface;
using Service.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _workerLogger;
        private readonly ILogger<Adapter> _adapterLogger;
        private ServiceConfiguration _config;
        private List<Assembly> _dlls = new List<Assembly>();
        private Dictionary<Adapter, List<IAdapterSource>> _adapters { get; set; }
            = new Dictionary<Adapter, List<IAdapterSource>>();

        public Worker(ILogger<Worker> workerLogger,ILogger<Adapter> adapterLogger, ServiceConfiguration config)
        {
            _workerLogger = workerLogger;
            _adapterLogger = adapterLogger;
            _config = config;

            _initialize();
        }
        private void _initialize()
        {
            _adapters = new Dictionary<Adapter, List<IAdapterSource>>();

            _importDlls();

            foreach (var dll in _dlls)
            {
                var adapterTypes = dll.GetTypes().Where(o => !o.IsInterface && !o.IsAbstract && o.IsSubclassOf(typeof(Adapter)));

                foreach (var adapterType in adapterTypes)
                {
                    var adapterConfig = _config.Adapters.FirstOrDefault(o => o.Adapter == adapterType.Name || o.Adapter == adapterType.FullName);
                    if (adapterConfig == null)
                    {
                        _workerLogger?.LogWarning("Could not find configuration for Adapter implementation {AdapterType}", adapterType.FullName);
                        continue;
                    }

                    //AdapterOptions result, ILogger<Adapter> workerLogger = null
                    var adapterCtors = adapterType.GetConstructors();
                    foreach (var adapterCtor in adapterCtors)
                    {
                        var optionsParam = adapterCtor.GetParameters().FirstOrDefault(o => o.ParameterType.IsSubclassOf(typeof(AdapterOptions)));
                        object? options = _constructFromConfig(adapterConfig.Options, optionsParam?.ParameterType);

                        var adapter = adapterCtor.Invoke(new object?[] { options, _adapterLogger }) as Adapter;
                        if (adapter == null)
                        {
                            _workerLogger?.LogError(new InvalidCastException("Failed to construct Adapter"), "Failed to construct Adapter { AdapterType }", adapterType.FullName);
                            continue;
                        }
                        if (!_adapters.TryAdd(adapter, new List<IAdapterSource>()))
                        {
                            _workerLogger?.LogError(new ArgumentNullException(), "Failed to add Adapter { AdapterType }, likely already added", adapterType.FullName);
                            continue;
                        }
                    }
                }
            }

            foreach (var dll in _dlls)
            {
                var sourceTypes = dll.GetTypes().Where(o => typeof(IAdapterSource).IsAssignableFrom(o) && !o.IsInterface && !o.IsAbstract);

                foreach (var sourceType in sourceTypes)
                {
                    var sourceConfig = _config.Sources?.FirstOrDefault(o => o.Source == sourceType.Name || o.Source == sourceType.FullName);
                    IAdapterSource? source = _constructFromConfig(sourceConfig?.Options, sourceType) as IAdapterSource;
                    if (source == null)
                    {
                        _workerLogger?.LogError(new InvalidCastException("Failed to construct IAdapterSource"), "Failed to construct IAdapterSource { SourceType }", sourceType.FullName);
                        continue;
                    }

                    var adapterConfigs = _config.Adapters.Where(o => o.Sources.Contains(sourceType.Name) || o.Sources.Contains(sourceType.FullName));

                    foreach (var adapterConfig in adapterConfigs)
                    {
                        var adapter = _adapters
                            .Keys
                            .FirstOrDefault(o => o.GetType().Name == adapterConfig.Adapter || o.GetType().FullName == adapterConfig.Adapter);
                        if (adapter == null)
                        {
                            _workerLogger?.LogError("Could not find adapter for IAdapterSource according to configuration");
                            continue;
                        }

                        _adapters[adapter].Add(source);
                    }
                }
            }
        }
        private object? _constructFromConfig(object? config, Type targetType)
        {
            Type? configType = config?.GetType();
            bool isDictionary = config is IDictionary<string, object?>;

            object? result = null;
            var ctors = targetType.GetConstructors().OrderByDescending(o => o.GetParameters()?.Length);
            foreach (var ctor in ctors)
            {
                var ctorParams = ctor.GetParameters();

                List<object?> resultParams = new List<object?>();
                foreach (var ctorParam in ctorParams)
                {
                    object? value = null;
                    if (isDictionary)
                    {
                        if ((config as IDictionary).Contains(ctorParam.Name))
                        {
                            value = (config as IDictionary)[ctorParam.Name];
                        }
                    } else
                    {
                        var property = configType?.GetProperty(ctorParam.Name);
                        if (property != null)
                        {
                            value = property.GetValue(config, null);
                        }
                    }

                    if (value != null)
                    {
                        value = Convert.ChangeType(value, ctorParam.ParameterType);

                        resultParams.Add(value);
                    } else if (ctorParam.IsOptional)
                    {
                        resultParams.Add(ctorParam.DefaultValue);
                    }
                }
                if (resultParams.Count == ctorParams.Length)
                {
                    result = ctor.Invoke(resultParams.ToArray());
                    if (result != null) break;
                }
            }

            if (result == null)
            {
                _workerLogger?.LogError("Could not construct {AdapterOptionsType}", targetType.FullName);
                return null;
            }

            Dictionary<string, object?>? configProperties = null;
            if (isDictionary)
            {
                configProperties = (config as Dictionary<string, object?>);
            }
            else
            {
                configProperties = configType?.GetProperties().ToDictionary(o => o.Name, o => o.GetValue(config, null));
            }
            if (configProperties != null)
            {
                foreach (var kvp in configProperties)
                {
                    var property = targetType.GetProperty(kvp.Key);
                    if (property == null) continue;

                    property.SetValue(result, kvp.Value);
                }
            }

            return result;
        }
        private void _importDlls()
        {
            foreach (var importDll in _config.Imports)
            {
                var dllFilename = Path.Combine(Directory.GetParent(Environment.ProcessPath).FullName, importDll);
                if (!File.Exists(dllFilename))
                {
                    _workerLogger?.LogError(new DllNotFoundException("Could not find Adapter DLL"), "Could not find Adapter DLL { AdapterFilename }", dllFilename);
                    continue;
                }

                var dll = Assembly.Load(File.ReadAllBytes(dllFilename));
                if (dll == null)
                {
                    _workerLogger?.LogError(new FileLoadException("Failed to load Adapter DLL", dllFilename), "Failed to load Adapter DLL { AdapterFilename }", dllFilename);
                    continue;
                }
                _dlls.Add(dll);
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _workerLogger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            if (!_dlls.Any())
            {
                _workerLogger?.LogError("Missing Imports in configuration", _config);
                return;
            }

            if (!_adapters.Any())
            {
                _workerLogger?.LogError("Missing Adapters in configuration", _config);
                return;
            }

            if (!_adapters.SelectMany(o => o.Value).Any())
            {
                _workerLogger?.LogError("Missing IAdapterSources in configuration", _config);
                return;
            }

            _start(stoppingToken);

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);
            }

            _stop();
        }

        private void _start(CancellationToken token)
        {
            foreach (var adapterKvp in _adapters)
            {
                adapterKvp.Key.Start(adapterKvp.Value, token: token);
                _workerLogger?.LogInformation("Started Adapter {AdapterType}", adapterKvp.Key.GetType().FullName);
            }
        }
        private void _stop()
        {
            foreach (var adapterKvp in _adapters)
            {
                adapterKvp.Key.Stop();
            }
        }
    }
}