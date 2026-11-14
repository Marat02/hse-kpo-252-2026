using HSE.KPO.Application.Interfaces;
using HSE.KPO.Application.Services;
using HSE.KPO.Infrastructure;
using HSE.KPO.Infrastructure.Extensions;
using HSE.KPO.Sales.Application;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddCarsInfrastructure();
builder.Services.AddScoped<ICarService, CarService>();

builder.Services.AddMassTransit(x =>
{
    x.AddConsumers(typeof(ISalesApplicationMarker).Assembly);
    x.UsingInMemory((context, configurator) => configurator.ConfigureEndpoints(context));
});

var app = builder.Build();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => { options.SwaggerEndpoint("/openapi/v1.json", "v1"); });
}

app.UseHttpsRedirection();
await CarsStartup.Migrate(app.Services);
app.Run();