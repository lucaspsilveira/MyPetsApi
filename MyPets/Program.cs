using MyPets;
using MyPets.Database;
using MyPets.Repositories;
using MyPets.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPetsRepository, PetsRepository>();
builder.Services.AddScoped<IPetsService, PetsService>();
builder.Services.AddScoped<ITutorsRepository, TutorsRepository>();
builder.Services.AddScoped<ITutorsService, TutorsService>();
builder.Services.AddDbContext<MyPetsDatabaseContext>();

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