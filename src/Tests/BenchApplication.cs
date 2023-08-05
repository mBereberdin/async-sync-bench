namespace Tests;

using bench;

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Приложение бенчмарка.
/// </summary>
public class BenchApplication : WebApplicationFactory<Program>
{
    /// <summary>
    /// Окружающая среда.
    /// </summary>
    private readonly string _environment;

    /// <inheritdoc cref="BenchApplication"/>
    /// <param name="environment">Окружающая среда.</param>
    public BenchApplication(string environment = "Development")
    {
        _environment = environment;
    }

    /// <summary>
    /// Создать хост.
    /// </summary>
    /// <param name="builder">Строитель приложения.</param>
    /// <returns>Хост.</returns>
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.UseEnvironment(_environment);

        // Здесь можно добавить сервисы.
        builder.ConfigureServices(services => { });

        var host = base.CreateHost(builder);

        return host;
    }
}