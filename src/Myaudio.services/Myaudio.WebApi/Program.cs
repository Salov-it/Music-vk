using MediatR;
using Microsoft.Extensions.Configuration;
using Myaudio.Application;
using Myaudio.Application.CQRS.Command.GetMyaudio;
using Myaudio.Application.CQRS.Command.GetMyaudioDowload;
using Myaudio.persistance;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddMediatR(typeof(Program).Assembly); //Регистрация медиатра
builder.Services.AddApplication();
builder.Services.AddScoped<MyaudiosContext>();



// Add services to the container.

builder.Services.AddControllers();
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
