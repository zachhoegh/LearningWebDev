var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    var html = await File.ReadAllTextAsync("wwwroot/index.html");
    return Results.Content(html, "text/html");
});

app.Run();
