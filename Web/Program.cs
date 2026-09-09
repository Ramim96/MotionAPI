using Infrastructure.DependencyInjection;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File(
        "logs/Startup-AppLogs-.txt",
        rollingInterval: RollingInterval.Day,
        retainedFileCountLimit: 7)
    .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting Motion API Server...");

    // Add services to the container.
    builder.Services.AddAppCoreConfig(builder.Configuration);


    builder.Services.AddControllers();
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
    }

    app.UseHttpsRedirection();
    app.UseSerilogRequestLogging();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Motion API server teminated unexpectedly.");
}
finally
{
    Log.CloseAndFlush();
}