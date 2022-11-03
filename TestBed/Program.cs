using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRequestLocalization(rlo =>
{
    List<CultureInfo> supportedCultures = new()
    {
        new("en"),
        new("es")
    };

    rlo.DefaultRequestCulture = new RequestCulture(supportedCultures[0]);
    rlo.SupportedCultures = supportedCultures;
    rlo.SupportedUICultures = supportedCultures;
});

builder.Services
    .AddRazorPages()
    .AddViewLocalization(o =>
    {
        o.ResourcesPath = "Resources";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRequestLocalization();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();