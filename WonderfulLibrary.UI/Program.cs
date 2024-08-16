using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.FlowAnalysis;
using System.Reflection;
using WonderfulLibrary.Application.Query;
using WonderfulLibrary.UI.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile(new UIProfile());
});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetBooksQuery).Assembly));

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
