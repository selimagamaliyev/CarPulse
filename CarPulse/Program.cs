using CarPulse.Application.AutoMap;
using CarPulse.Application.IServices;
using CarPulse.Infrastructure.Context;
using CarPulse.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Mapping));
builder.Services.AddDbContext<CarContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserContextConnectionString"));
});
builder.Services.AddScoped<IAnnouncementServices, AnnouncementServices>();
builder.Services.AddScoped<ISalesmanServices, SalesmanServices>();
builder.Services.AddScoped<ICarServices, CarServices>();
builder.Services.AddScoped<IPhotoServices, PhotoServices>();
builder.Services.AddScoped<ISupplyServices, SupplyServices>();
builder.Services.AddScoped<IEngineServices, EngineServices>();
builder.Services.AddScoped<IPriceServices, PriceServices>();
builder.Services.AddScoped<IMileageServices, MileageServices>();
builder.Services.AddLogging();
builder.Services.AddControllersWithViews()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
