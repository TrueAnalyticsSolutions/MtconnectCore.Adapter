using Service;
using Service.Configuration;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        IConfiguration configuration = hostContext.Configuration;

        ServiceConfiguration? config = configuration.GetSection("Service").Get<ServiceConfiguration>();

        services.AddSingleton(config);

        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
