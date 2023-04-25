using Myaudio.Application;
using Myaudio.Application.CQRS.Command.GetMyaudio;
using Myaudio.Application.CQRS.Command.GetMyaudioDowload;
using Myaudio.Application.CQRS.Interface;
using Myaudio.Application.CQRS.Mapping;
using Myaudio.persistance;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IContext).Assembly));
});


//builder.Services.AddMediatR(typeof(Program).Assembly); //Регистрация медиатра
builder.Services.AddApplication();
builder.Services.AddPersistance(configuration);
builder.Services.AddScoped<IMyaudiosRepository, MyaudiosRepository>();
builder.Services.AddScoped<IVkApiService, VkApiService>();
builder.Services.AddScoped<ILooadin, LoadingMp3>();



// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviseProvider = scope.ServiceProvider;
    try
    {
        var context = serviseProvider.GetRequiredService<Context>();
        DbInit.init(context);
    }
    catch (Exception ex)
    {

    }
};

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
