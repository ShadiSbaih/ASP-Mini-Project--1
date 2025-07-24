var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//---------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//---------------
builder.Services.AddDbContext<MyFirstRestApi.Models.Db.RestApiDbContext>();
//---------------
var app = builder.Build();

// Configure the HTTP request pipeline.
//--------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
//--------------------
app.UseAuthorization();

app.MapControllers();

app.Run();
