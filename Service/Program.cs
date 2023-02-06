using Serilog;
using Service;
using Service.Configuration;

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(options =>
    {
        options.ServiceName = "MTConnect Adapter";
    })
    .ConfigureServices((hostContext, services) =>
    {
        IConfiguration configuration = hostContext.Configuration;

        Serilog.Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(configuration)
        .CreateLogger();

        services.AddLogging((o) =>
        {
            o.AddSerilog(dispose: true);
        });

        ServiceConfiguration? config = configuration.GetSection("Service").Get<ServiceConfiguration>();

        services.AddSingleton(config);
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
