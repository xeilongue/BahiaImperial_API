/*
 * dotnet ef migrations add Inicial
 * dotnet ef database update
 * 
 * - configurar as restrições
 * 
 * 
 * 
 * 
 * 
 * 
*/

using BahiaImperial_API.Data;
using BahiaImperial_API.Repositories.AccountRepo;
using BahiaImperial_API.Repositories.ClientRepo;
using BahiaImperial_API.Repositories.TransactionRepo;
using BahiaImperial_API.Repositories.UserRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// REGISTRO DO REPOSITÓRIO
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

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
