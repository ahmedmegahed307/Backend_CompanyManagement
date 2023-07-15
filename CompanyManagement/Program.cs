using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using DataAccess.InfraStructure;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Abstract.IEntityFramework;
using Business.Helper.AutoMapper;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<CompanyContext>((serviceProvider, options) =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    DatabaseConfiguration.Configure(options, configuration);
});

builder.Services.AddSwaggerGen();
builder.Services.AddCors();

//*****Dependency Injection*****//

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(ResolutionMapper));

//Resolution
builder.Services.AddScoped<IResolutionService, ResolutionService>();
builder.Services.AddScoped<IResolutionDal, ResolutionDal>();

//Client
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IClientDal, ClientDal>();

//User
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserDal, UserDal>();

//JobType
builder.Services.AddScoped<IJobTypeService, JobTypeService>();
builder.Services.AddScoped<IJobTypeDal, JobTypeDal>();

//JobSubType
builder.Services.AddScoped<IJobSubTypeService, JobSubTypeService>();
builder.Services.AddScoped<IJobSubTypeDal, JobSubTypeDal>();



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
