namespace bench.Services;

/// <summary>
/// Тестовый сервис.
/// </summary>
public class TestService
{
    /// <summary>
    /// Получить строку асинхронно.
    /// </summary>
    /// <returns>Строка.</returns>
    public async Task<string> GetStringAsync()
    {
        return await Task.Run(() =>
        {
            // Симуляция ожидания внешней системы (вызов api, бд и тд.)
            Thread.Sleep(2000);

            return "HelloWorld";
        });
    }

    /// <summary>
    /// Получить строку синхронно.
    /// </summary>
    /// <returns>Строка.</returns>
    public string GetString()
    {
        // Симуляция ожидания внешней системы (вызов api, бд и тд.)
        Thread.Sleep(2000);

        return "HelloWorld";
    }
}