var app = WebApplication.Create(args);

app.Services.AddHealthChecks();

app.MapHealthChecks("/health");
app.MapGet("/", () => "Hello World!");

await app.RunAsync();
