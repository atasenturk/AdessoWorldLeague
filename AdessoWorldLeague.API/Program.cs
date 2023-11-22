using AdessoWorldLeague.Infrastructure.Data;
using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeague.Infrastructure.Repositories.Generic;
using AdessoWorldLeauge.Domain.Interfaces;
using AdessoWorldLeauge.Domain.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AdessoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdessoWorldLeagueConnStr")));

builder.Services.AddControllers();

builder.Services.AddCors(q => q.AddPolicy("AllowAll", policy => policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<DbContext, AdessoDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
