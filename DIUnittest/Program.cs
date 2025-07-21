var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddScoped<IMyService, MyService>();      // Scoped
builder.Services.AddTransient<IMyService2, MyService2>(); // Transient
builder.Services.AddSingleton<IMyService3, MyService3>(); // Singleton

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();
