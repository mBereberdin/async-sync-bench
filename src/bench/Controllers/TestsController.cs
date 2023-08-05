namespace bench.Controllers;

using bench.Services;

using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Тестовый контроллер.
/// </summary>
[Route("[controller]")]
[ApiController]
public class TestsController : ControllerBase
{
    /// <inheritdoc cref="TestService"/>
    private readonly TestService _testService;

    /// <inheritdoc cref="TestsController"/>
    /// <param name="testService">Тестовый сервис.</param>
    public TestsController(TestService testService)
    {
        _testService = testService;
    }

    /// <summary>
    /// Получить строку асинхронно.
    /// </summary>
    /// <returns>Строка в формате json.</returns>
    [HttpGet("async")]
    public async Task<IActionResult> GetStringAsync()
    {
        var testString = await _testService.GetStringAsync();

        return Ok(testString);
    }

    /// <summary>
    /// Получить строку синхронно.
    /// </summary>
    /// <returns>Строка в формате json.</returns>
    [HttpGet("sync")]
    public IActionResult GetString()
    {
        var testString = _testService.GetString();

        return Ok(testString);
    }
}