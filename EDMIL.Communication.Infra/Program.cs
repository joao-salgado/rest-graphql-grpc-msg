using EDMIL.Communication.Infra.Configs;
using EDMIL.Communication.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using HotChocolate.AspNetCore;
using HotChocolate.Types;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddUseCases();
builder.Services.AddGraphQLQueries();

//builder.Services.AddAppConections(builder.Configuration);

var connectionString = builder.Configuration.GetConnectionString("CommunicationDb");
builder.Services.AddDbContext<CommunicationDBContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();
app.MapControllers();
app.MapGraphQL("/graphql");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Apply migrations on startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<CommunicationDBContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        // Log the exception or handle it
        Console.WriteLine($"An error occurred while migrating the database: {ex.Message}");
    }
}

app.Run();
