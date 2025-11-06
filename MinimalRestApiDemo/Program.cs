using MinimalApi.EndPoints;
using MinimalApi.Repos;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<ProductRepository>();

var app = builder.Build();

app.MapProductEndpoints();



app.Run();
