using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Mapper;
using WebApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Database>(
	options => options.UseSqlite("Data Source=DataBase.db")
	);
builder.Services.AddAutoMapper(typeof(MapProfile));

//Add all controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapControllers();

app.Run();

