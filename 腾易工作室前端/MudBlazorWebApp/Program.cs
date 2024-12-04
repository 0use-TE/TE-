using Microsoft.JSInterop;
using MudBlazor.Services;
using MudBlazorWebApp.Components;
using MudBlazorWebApp.Data;
using MudBlazorWebApp.Models;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddSingleton<GameData>();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Add Cors
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll", builder =>
		builder.AllowAnyOrigin()
			   .AllowAnyMethod()
			   .AllowAnyHeader());
});


builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Listen(IPAddress.Any, 80); // 监听所有网络接口上的80端口  
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	Settings.URL = app.Configuration["URL"] ?? "http://106.54.7.121:25000/api"; // 默认值
	Settings.IP = app.Configuration["IP"] ?? "http://tegamecompany.com";
}
else
{
	Settings.URL = app.Configuration["DevelopmentURL"] ?? "http://localhost:25000/api"; // 默认值
	Settings.IP= app.Configuration["DevelopmentIP"] ?? "http://127.0.0.1"; // 默认值
}
app.UseCors("AllowAll");
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
//<MudPagination   Variant="Variant.Outlined" Count="3" Style="position: fixed; bottom: 10px; left: 50%; transform: translateX(-50%);" />