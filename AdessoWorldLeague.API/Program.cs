using AdessoWorldLeague.Infrastructure.Data;
using AdessoWorldLeague.Infrastructure.Repositories;
using AdessoWorldLeague.Infrastructure.Repositories.Generic;
using AdessoWorldLeague.Infrastructure.Services;
using AdessoWorldLeague.Infrastructure.Services.Interfaces;
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
builder.Services.AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<ICountriesRepository, CountriesRepository>();
builder.Services.AddTransient<IGroupRepository, GroupRepository>();
builder.Services.AddTransient<ITeamRepository, TeamRepository>();
builder.Services.AddTransient<IDrawTeamService, DrawTeamService>();
builder.Services.AddTransient<DbContext, AdessoDbContext>();

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
