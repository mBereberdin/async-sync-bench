using bench.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<TestService>();

var app = builder.Build();

app.MapControllers();

app.Run();

// Делает неявный класс Program общедоступным, чтобы к нему могли обращаться тестовые проекты
public partial class Program
{
}