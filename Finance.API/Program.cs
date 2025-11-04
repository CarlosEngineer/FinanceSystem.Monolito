using Finance.Application.Services.IService;
using Finance.Application.Services;
using Finance.Infra.Repositorios;
using Finance.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injeção de Dep. Repo
builder.Services.AddScoped<IEntrada, EntradaRepo>();
builder.Services.AddScoped<ISaida, SaidaRepo>();
builder.Services.AddScoped<IUsuario, UsuarioRepo>();


builder.Services.AddScoped<IEntradaService, EntradaService>();
builder.Services.AddScoped<ISaidaService, SaidaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();



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
