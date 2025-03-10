using dumbledore.DL;
using dumbledore.DL.Interfaces;
using dumbledore.Services;
using dumbledore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<ICrewRepository, CrewRepository>();
builder.Services.AddScoped<ICrewService, CrewService>();


builder.Services.AddDbContext<MovieContext>(
    options=>
    {
        options.UseSqlite("Data Source=main.db");
    }
);

builder.Services.AddDbContext<CrewContext>(
    options =>
    {
        options.UseSqlite("Data Source=main.db");
    }
);

builder.Services.AddDbContext<ReviewContext>(
    options =>
    {
        options.UseSqlite("Data Source=main.db");
    }
);

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
