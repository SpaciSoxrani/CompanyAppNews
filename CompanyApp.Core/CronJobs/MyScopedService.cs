namespace CompanyApp.Core.Domain.Services;

public interface IMyScopedService
{
    Task DoWork(CancellationToken cancellationToken);
}

public class MyScopedService : IMyScopedService
{
    private readonly ILogger<MyScopedService> _logger;

    public MyScopedService(ILogger<MyScopedService> logger)
    {
        _logger = logger;
    }

    public async Task DoWork(CancellationToken cancellationToken)
    {
        _logger.LogInformation($"{DateTime.Now:hh:mm:ss} MyScopedService is working.");
        await Task.Delay(1000 * 20, cancellationToken);
    }
}