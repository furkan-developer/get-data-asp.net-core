using BtkCamp.Models;
using BtkCamp.Models.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// builder.Services.AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<Program>());

builder.Services.AddFluentValidation();
builder.Services.AddScoped<IValidator<Candidate>,CandidateValidator>();


builder.Services.AddSingleton<ICollection<Candidate>>(new List<Candidate>());

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
