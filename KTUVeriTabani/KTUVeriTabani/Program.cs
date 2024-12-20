using Microsoft.EntityFrameworkCore;
using KTUVeriTabani.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

// MVC Route : on yuzde calismak icin gerekli
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=LoginUser}");

// API route Postman uzerinden calismasi icin gerekli
// API route Postman uzerinden calismasi icin gerekli
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();