using Microsoft.EntityFrameworkCore;
using TFL.DevOps.Api.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

if(builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<TflDbContext>(opt =>
        opt.UseInMemoryDatabase("TFL")
    );
}
else
{
    var connection = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTIONSTRING");
    builder.Services.AddDbContext<TflDbContext>(opt =>
        opt.UseSqlServer(connection)
    );
}

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
