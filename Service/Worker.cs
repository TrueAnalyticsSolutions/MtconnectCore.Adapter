using Mtconnect;
using Service.Configuration;
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
        private AdapterFactory _factory { get; set; }

        public Worker(ILogger<Worker> workerLogger,ILogger<Adapter> adapterLogger, ServiceConfiguration config)
        {
            _workerLogger = workerLogger;
            _adapterLogger = adapterLogger;
            _config = config;

            _initialize();
        }
        private void _initialize()
        {
            _factory = null;

            _importDlls();

            _factory = AdapterFactory.CreateFromTypes(_dlls, _config, _workerLogger, _adapterLogger);
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

            if (_factory == null)
            {
                var ex = new InvalidOperationException("AdapterFactory has not been initialized");
                _workerLogger?.LogError(ex, ex.Message);
                return;
            }

            _factory.Start(stoppingToken);

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);
            }

            _factory.Stop();
        }
    }
}