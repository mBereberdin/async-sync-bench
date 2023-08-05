namespace Tests.Tests;

using global::Tests.Scenarios;

using Xunit.Abstractions;

/// <summary>
/// Тесты тестового контроллера.
/// </summary>
public class TestsControllerTests
{
    /// <summary>
    /// Класс, который может быть использован для вывода результатов тестирования.
    /// </summary>
    private readonly ITestOutputHelper _testOutputHelper;

    /// <inheritdoc cref ="TestsControllerTests"/>
    /// <param name="testOutputHelper">Класс, который может быть использован для вывода результатов тестирования.</param>
    public TestsControllerTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// Тест синхронной конечной точки.
    /// </summary>
    [Fact]
    public void SyncTest()
    {
        ExecuteWithThreadsInfoAndGcClean("tests/sync");
    }

    /// <summary>
    /// Тест асинхронной конечной точки.
    /// </summary>
    [Fact]
    public void AsyncTest()
    {
        ExecuteWithThreadsInfoAndGcClean("tests/async");
    }

    /// <summary>
    /// Выполнить с информацией о потоках и уборкой мусора.
    /// </summary>
    /// <param name="url">Адрес запроса.</param>
    private void ExecuteWithThreadsInfoAndGcClean(string url)
    {
        using var application = new BenchApplication();
        using var client = application.CreateClient();
        var scenario = TestsControllerScenarios.GetAsync(client, url);

        FormatAndPrintMessageWithThreadsInfo("Колличество имеющихся потоков для теста перед выполнением: {0}");
        TestsControllerScenarios.Run(scenario);
        FormatAndPrintMessageWithThreadsInfo("Колличество имеющихся потоков после выполнения: {0}");

        GC.Collect();
    }

    /// <summary>
    /// Вывод сообщения с ифнормацией о потоках.
    /// </summary>
    /// <param name="message">Сообщение, в которое необходимо подставить кол-во потоков.</param>
    private void FormatAndPrintMessageWithThreadsInfo(string message)
    {
        var formattedMessage = string.Format(message, ThreadPool.ThreadCount.ToString());
        _testOutputHelper.WriteLine(formattedMessage);
    }
}