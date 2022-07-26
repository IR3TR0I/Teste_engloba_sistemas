global using Microsoft.AspNetCore.Mvc;
global using System.Diagnostics;
global using EnglobaSistemasTeste;
global using Microsoft.EntityFrameworkCore;
using EnglobaSistemasTeste.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EnglobaContext>(x => x.UseSqlServer("Data Source=DESKTOP-B9BU4K8\\SQLEXPRESS; initial catalog=EnglobaSistemas; user Id=sa; pwd=senai@132;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
