using RecruitFlow.API.ExceptionHandling;
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

// API Filters
builder.Services.AddScoped(typeof(ValidationFilter<>));

// Exception Handling
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseExceptionHandler();

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
