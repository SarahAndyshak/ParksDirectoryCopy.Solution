using ParksDirectory.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add in a Cors Policy to get around Cors issue (see bottom of Program.cs as well) using this link https://stackoverflow.com/questions/70511588/how-to-enable-cors-in-asp-net-core-6-0-web-api-project

var devCorsPolicy = "devCorsPolicy";
builder.Services.AddCors(options => options.AddPolicy(devCorsPolicy, builder =>
  {
    builder
      // .WithOrigins("https://localhost:3000")
      .AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader();
      // .AllowCredentials();
  }));

builder.Services.AddDbContext<ParksDirectoryContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], 
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else 
{
  app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors(devCorsPolicy);

app.Run();