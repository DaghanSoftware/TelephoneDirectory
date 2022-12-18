using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TelephoneDirectory.Core.Repositories;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Core.UnitOfWorks;
using TelephoneDirectory.Repository;
using TelephoneDirectory.Repository.Repositories;
using TelephoneDirectory.Repository.UnitOfWorks;
using TelephoneDirectory.Service.Mapping;
using TelephoneDirectory.Service.Services;
using TelephoneDirectory.Service.Validations;
using FluentValidation.AspNetCore;
using TelephoneDirectory.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.WebAPI.Middlewares;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using TelephoneDirectory.WebAPI.Modules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => { options.Filters.Add(new ValidationFilterAttribute()); }).AddFluentValidation(x =>
x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(NotFoundFilter<>));

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerbuilder => containerbuilder.RegisterModule(new RepoServiceModule()));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
