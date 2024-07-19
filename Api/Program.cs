using Microsoft.EntityFrameworkCore;
using TFL.DevOps.Api.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var connection = builder.Configuration.GetConnectionString("TflSchoolApiContext");
builder.Services.AddDbContext<TflDbContext>(opt =>
    opt.UseSqlServer(connection, sqlOptions => sqlOptions.EnableRetryOnFailure())
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
