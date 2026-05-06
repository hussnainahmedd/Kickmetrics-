using KickMetrics;
using KickMetrics.Components;
using KickMetrics.Data;
using KickMetrics.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// ✅ SERVICES (SRP)
builder.Services.AddScoped<IPlayerService, PlayerService>();

// ✅ CALCULATORS (OCP - separate services)
builder.Services.AddScoped<PerformanceCalculator>();
builder.Services.AddScoped<FitnessCalculator>();
builder.Services.AddScoped<InjuryCalculator>();


var app = builder.Build();

// Configure HTTP pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();