using RecruitFlow.API.Filters;
using RecruitFlow.Application;
using RecruitFlow.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Application Layer
builder.Services.AddApplication();

// Infrastructure Layer
builder.Services.AddInfrastructure(
    builder.Configuration);

builder.Services.AddScoped(typeof(ValidationFilter<>));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
