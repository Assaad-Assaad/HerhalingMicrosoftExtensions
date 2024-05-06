using Microsoft.Extensions.Options;

namespace Herhaling_MicrosoftExtensions;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IServiceProvider _serviceProvider;
    private readonly Config _config;

    public Worker(IServiceProvider serviceProvider, ILogger<Worker> logger, IOptions<Config> config)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        _config = config.Value;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Test worker class");

        Console.WriteLine($"Config Settings: {_config.Settings}");

        var serviceA = _serviceProvider.GetRequiredService<ServiceA>();
        await serviceA.Process();

        using (var scope = _serviceProvider.CreateScope())
        {
            var serviceB = scope.ServiceProvider.GetRequiredService<ServiceB>();
            await serviceB.Process();
        }

        var serviceC = _serviceProvider.GetRequiredService<ServiceC>();
        await serviceC.Process();
    }
}