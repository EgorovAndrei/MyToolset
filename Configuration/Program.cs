using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Configuration.AddJsonFile("appsettings.json")
//    .AddJsonFile($"appsettings.{app.Environment.EnvironmentName}.json");
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    // пути для SetBasePath
    var binPathLocal = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    var binPathRelease = hostingContext.HostingEnvironment.ContentRootPath;

    config
    .SetBasePath(binPathLocal)
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json",true, true)
    .AddEnvironmentVariables();

    if(args != null)
    {
        config.AddCommandLine(args);
    }
});

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
