using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System;
using WebApi;
using WebApi.BusinessControllers;
using WebApi.BusinessControllers.Interfaces;
using WebApi.Extensions;
using WebApi.Model;
using WebApi.Repository;
using WebApi.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Swagger
builder.Services.AddSwaggerGen(swaggerGenOptions =>
{
    swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Product API",
        Version = "v1",
        Description = "Product WebAPI provides product data and allows you to update the product description"
    });

    swaggerGenOptions.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Bearer token.",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    swaggerGenOptions.OperationFilter<Swashbuckle.AspNetCore.Filters.SecurityRequirementsOperationFilter>();
    swaggerGenOptions.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line

    swaggerGenOptions.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"doc/documentation.xml"));
});

// Add CORS policy
var corsConfig = builder.Configuration.GetSection("Cors").AsEnumerable().Select(k => k.Value).Where(k => !string.IsNullOrEmpty(k)).ToArray();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
    builder =>
    {
        builder.WithOrigins(corsConfig)
                            .SetIsOriginAllowedToAllowWildcardSubdomains()
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowCredentials()
                            .WithExposedHeaders("rowcount");
    });
});

//Business logic
builder.Services.AddTransient<IProductBusinessController, ProductBusinessController>();
//Reposirtory
builder.Services.AddScoped<IProductRepository, ProductRepository>();
// DB
builder.Services.AddDbContextPool<WebApiContext>(options => options.OnConfigure(builder.Configuration, "WebApiDB"));

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetService<WebApiContext>();
if (context == null) throw new Exception("Context is null");
//context.EnsureCreated();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
