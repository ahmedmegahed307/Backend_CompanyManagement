using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using DataAccess.InfraStructure;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<CompanyContext>((serviceProvider, options) =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    DatabaseConfiguration.Configure(options, configuration);
});

builder.Services.AddSwaggerGen();
builder.Services.AddCors();

//Dependency Injection
builder.Services.AddScoped<IResolutionService, ResolutionService>();
builder.Services.AddScoped<IResolutionDal, ResolutionDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:5173")
           .AllowAnyMethod()
           .AllowAnyHeader();
});
app.MapControllers();

app.Run();
