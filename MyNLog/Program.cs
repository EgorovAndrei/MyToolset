
//https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6
//https://github.com/NLog/NLog/wiki/Configuration-file

using NLog;
using NLog.Web;

NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{


    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();


    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthorization();


    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    // NLog: catch setup errors
    logger.Error(ex);
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}
