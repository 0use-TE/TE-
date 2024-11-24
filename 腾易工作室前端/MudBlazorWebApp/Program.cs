using Microsoft.JSInterop;
using MudBlazor.Services;
using MudBlazorWebApp.Components;
using MudBlazorWebApp.Data;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddSingleton<GameData>();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Listen(IPAddress.Any, 80); // 监听所有网络接口上的25000端口  
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
//<MudPagination   Variant="Variant.Outlined" Count="3" Style="position: fixed; bottom: 10px; left: 50%; transform: translateX(-50%);" />