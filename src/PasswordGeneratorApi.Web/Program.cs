using Microsoft.AspNetCore.Mvc;
using PasswordGeneratorApi.DependencyInjection;
using PasswordGeneratorApi.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDomainServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

// app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");


// app.MapGet("/GeneratePassword/{scheme}", ([FromQuery] string scheme, [FromServices] IPasswordGeneratorFactory generatorFactory) =>
// {
//     var passwordGenerator = generatorFactory.CreatePasswordGenerator(scheme);
//     return passwordGenerator.GeneratePassword();
// });

app.MapGet("/GeneratePassword/{scheme}", (string scheme, [FromServices] IPasswordGeneratorFactory generatorFactory) =>
{
    var passwordGenerator = generatorFactory.CreatePasswordGenerator(scheme);
    return passwordGenerator.GeneratePassword();
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "5010";

app.Run($"http://*:{port}");
record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}