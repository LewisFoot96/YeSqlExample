using YeSql.Net;
using YeSqlExample.ApiService.Domain;
using YeSqlExample.ApiService.Endpoints;
using YeSqlExample.ApiService.Infrastructure.Respoitories;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

builder.AddSqlServerClient("myConnection");

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(Exam).Assembly));

builder.Services.AddScoped<IExamRepository, ExamRepository>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Loads the SQL files from a default directory called yesql.
ISqlCollection sqlStatements = new YeSqlLoader().LoadFromDefaultDirectory();
// Adds the returned instance as a singleton service.
builder.Services.AddSingleton<ISqlCollection>(sqlStatements);
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapDefaultEndpoints();

app.MapExamEndpoints();

app.Run();

