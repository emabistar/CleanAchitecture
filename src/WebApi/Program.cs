using Application;
using Infranstructure;
using Presentation;
using Serilog;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IServiceCollection serviceCollection = builder.Services
       .AddApplication()
       .AddInfrastructure()
       .AddPresentation();
builder.Host.UseSerilog((Context, configuration) => configuration.ReadFrom.Configuration(Context.Configuration));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

