using CharacterCreator.Services.Services.TeamServices;
using CharacterCreator.Services.Services.FeatureServices;
using CharacterCreator.Services.Services.CharacterServices;
using Microsoft.Extensions.DependencyInjection;
using CharacterCreator.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();


// add connection string and dbcontext setup// add connection string and dbcontext setup
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
