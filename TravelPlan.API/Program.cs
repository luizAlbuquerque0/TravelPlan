using MediatR;
using Microsoft.EntityFrameworkCore;
using TravelPlan.Application.Commands.CreateViagem;
using TravelPlan.Core.Repositories;
using TravelPlan.Infrastructure.Persistence;
using TravelPlan.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("TravelPlanCs");
builder.Services.AddDbContext<TravelPlanDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddMediatR(typeof(CreateViagemCommand));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IViagemRepository, ViagemRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
