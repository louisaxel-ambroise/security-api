const string FileName = "registered.ip";

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/register", (HttpContext ctx) => File.WriteAllText(FileName, ctx.Connection.RemoteIpAddress?.ToString()));
app.MapGet("/live", () => Results.Redirect($"http://{File.ReadAllText(FileName)}:8081"));
app.MapGet("/ip", () => Results.Ok(File.ReadAllText(FileName)));
app.Run();