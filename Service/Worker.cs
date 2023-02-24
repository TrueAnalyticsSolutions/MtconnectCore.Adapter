using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Mtconnect;
using Service.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private ServiceConfiguration _config;
        private List<Assembly> _dlls = new List<Assembly>();
        private AdapterFactory _factory { get; set; }

        public Worker(ILoggerFactory logFactory, ServiceConfiguration config)
        {
            _logger = logFactory.CreateLogger<Worker>();
            _config = config;

            _initialize(logFactory);
        }
        private void _initialize(ILoggerFactory logFactory)
        {
            _factory = null;

            _importDlls();

            _factory = AdapterFactory.CreateFromTypes(_dlls, _config, logFactory);
        }
        
        private void _importDlls()
        {
            foreach (var importDll in _config.Imports)
            {
                var dllFilename = Path.Combine(Directory.GetParent(Assembly.GetEntryAssembly().Location).FullName, importDll);
                if (!File.Exists(dllFilename))
                {
                    _logger?.LogError(new DllNotFoundException("Could not find Adapter DLL"), "Could not find Adapter DLL {AdapterFilename}", dllFilename);
                    continue;
                }

                var dll = Assembly.UnsafeLoadFrom(dllFilename);
                if (dll == null)
                {
                    _logger?.LogError(new FileLoadException("Failed to load Adapter DLL", dllFilename), "Failed to load Adapter DLL {AdapterFilename}", dllFilename);
                    continue;
                }

                _logger?.LogInformation("Loaded assembly from file. {DllFilename}", dllFilename);
                _dlls.Add(dll);
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger?.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            if (!_dlls.Any())
            {
                _logger?.LogError("Missing Imports in configuration", _config);
                return;
            }

            if (_factory == null)
            {
                var ex = new InvalidOperationException("AdapterFactory has not been initialized");
                _logger?.LogError(ex, ex.Message);
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