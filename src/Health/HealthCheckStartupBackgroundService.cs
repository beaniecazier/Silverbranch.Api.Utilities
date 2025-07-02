using Gay.Silverbranch.Api.Utilities.Endpoints.V1.Health;
using Gay.Silverbranch.Utilities.General.BackgroundServices;

namespace Gay.Silverbranch.API.Utilities.Common.Health;

#pragma warning disable CS1591
public class HealthCheckStartupBackgroundService : StartupBackgroundService
{
    private readonly StartupCheckEndpoint _healthCheck;

    public HealthCheckStartupBackgroundService(StartupCheckEndpoint healthCheck)
        => _healthCheck = healthCheck;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await base.ExecuteAsync(stoppingToken);

        _healthCheck.StartupCompleted = true;
    }
}

#pragma warning restore CS1591