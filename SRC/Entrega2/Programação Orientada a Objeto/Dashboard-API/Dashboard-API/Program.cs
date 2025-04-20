using Dashboard_API.Data; 
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Dashboard_API.Services; // Para registrar o IUsuarioService e UsuarioService
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Dashboard_API.Model;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do banco com MySQL
builder.Services.AddDbContext<DashboardContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 29))));

// Registra o serviço IUsuarioService e sua implementação UsuarioService
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

// REGISTRA O HASHER DE SENHA
builder.Services.AddScoped<IPasswordHasher<Usuario>, PasswordHasher<Usuario>>();

// Adiciona os controladores
builder.Services.AddControllers();

// Configurações para o Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona suporte a arquivos estáticos (caso necessário para upload de imagens ou outros arquivos)
builder.Services.AddDirectoryBrowser();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapeia os controllers da API
app.MapControllers();

// Permite o uso de arquivos estáticos (exemplo para imagens de banners)
app.UseStaticFiles();

app.Run();