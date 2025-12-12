using Application.Interfaces;
using ClassLibrary1;
using HotelManagement.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddConnections();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();

builder.Services.AddScoped<IMenuServices, MenuServices>();

builder.Services.AddSqlServer<HositalManagementDbContext>(
    builder.Configuration.GetConnectionString("HotelManagementDbConnectionString")
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

// DO NOT USE app.UseMvc() in .NET 6/7/8
app.MapControllers();

app.UseCors();

app.Run();
