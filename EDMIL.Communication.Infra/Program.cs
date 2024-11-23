using EDMIL.Communication.Infra.Configs;
using EDMIL.Communication.Infra.Repositories;
//using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddUseCases();
//builder.Services.AddAppConections(builder.Configuration);

//builder.Services.AddDbContext<CommunicationDBContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("CommunicationDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
