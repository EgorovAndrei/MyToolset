var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//------------------------------------------------------------------------------
int x = 2;
app.Use((context, next) =>
{
    x = x * 2;      
    //return next(); 

    x = x * 2*2;

    var t = x * 2 * 2;

    var z = x * 2 * 2;

    return next();

    return context.Response.WriteAsync($"Result: {x}");

    return next();
});

app.Run((context) =>
{
    x = x * 2;  //  4 * 2 = 8
    return Task.FromResult(0);
});
//------------------------------------------------------------------------------

app.UseAuthorization();

app.MapControllers();

app.Run();


