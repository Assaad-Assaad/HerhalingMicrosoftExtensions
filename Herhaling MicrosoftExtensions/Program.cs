using Herhaling_MicrosoftExtensions;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<ServiceA>();
builder.Services.AddScoped<ServiceB>();
builder.Services.AddTransient<ServiceC>();

builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.Configure<Config>(builder.Configuration.GetSection("Config"));



var host = builder.Build();
host.Run();
