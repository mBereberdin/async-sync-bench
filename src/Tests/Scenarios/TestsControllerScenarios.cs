namespace Tests.Scenarios;

using NBomber.Contracts;
using NBomber.CSharp;

/// <summary>
/// Сценарии для контроллера тестов.
/// </summary>
public static class TestsControllerScenarios
{
    /// <summary>
    /// Получить стандартные настройки симуляции.
    /// </summary>
    /// <remarks>
    /// Запросов симуляции - 100,
    /// Временной интервал отправки запросов - 1 сек,
    /// Длительность симуляции - 100 сек.
    /// </remarks> 
    private static LoadSimulation GetSimulationSettingsDefault => Simulation.Inject(100,
        TimeSpan.FromSeconds(1),
        TimeSpan.FromSeconds(100));

    private static TimeSpan GetWarmupDefault => TimeSpan.FromSeconds(5);

    /// <summary>
    /// Выполнить сценарий.
    /// </summary>
    /// <param name="scenario">Сценарий, который необходимо выполнить.</param>
    public static void Run(ScenarioProps scenario)
    {
        NBomberRunner
            .RegisterScenarios(scenario)
            .Run();
    }

    /// <summary>
    /// Получить сценарий для GET запроса.
    /// </summary>
    /// <param name="client">Клиент для отправки запросов.</param>
    /// <param name="url">Адрес запроса.</param>
    /// <returns></returns>
    public static ScenarioProps GetAsync(HttpClient client, string url)
    {
        return Scenario.Create($"Обращение по адресу: {url}.", async _ =>
            {
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return Response.Fail(statusCode: response.StatusCode.ToString());
                }

                return Response.Ok(statusCode: response.StatusCode.ToString());
            })
            .WithWarmUpDuration(GetWarmupDefault)
            .WithLoadSimulations(GetSimulationSettingsDefault);
    }
}