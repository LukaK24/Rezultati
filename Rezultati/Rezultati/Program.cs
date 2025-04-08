using Rezultati; 



using Microsoft.EntityFrameworkCore;
using Rezultati.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//dodati ovu liniju za swagger
builder.Services.AddSwaggerGen();

// dodavanje kontaksta baze podataka - dependency injection
builder.Services.AddDbContext<RezultatiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RezultatiContext"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// dodati ove dvije linije za swagger
app.UseSwagger();
app.UseSwaggerUI(o => {
    o.EnableTryItOutByDefault();
    o.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled", true);
});


app.MapControllers();

app.Run();
