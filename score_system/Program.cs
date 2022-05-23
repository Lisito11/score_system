using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using score_system;
using Microsoft.Extensions.Configuration;
using score_system.Repositories.EF;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
//var dbConnection = config["DBCONNECTION"];


var dbConnection = Environment.GetEnvironmentVariable("DBCONNECTION");

#region AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
#endregion

#region Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Api Score System",
        Description = "An ASP.NET Core Web API for Score System",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Score System",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Licencia de la api",
            Url = new Uri("https://example.com/contact")
        }
    });
});

#endregion

#region Cors Policy
builder.Services.AddCors(c =>
{

    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
#endregion

builder.Services.AddDbContext<DBScoreContext>(options => options.UseNpgsql(dbConnection!.ToString()));

builder.Services.AddScoped<EFCompetitorRepository>();
builder.Services.AddScoped<EFEventRepository>();
builder.Services.AddScoped<EFRewardRepository>();
builder.Services.AddScoped<EFTeamRepository>();
builder.Services.AddScoped<EFScoreRepository>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{

}


app.UseCors("AllowOrigin");

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
