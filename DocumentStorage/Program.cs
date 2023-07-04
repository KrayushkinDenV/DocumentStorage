//---Services---//
using DocumentStorage.Repositories;
//---Context---//
using DocumentStorage.Data;
//---Packages---//
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DocumentsContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DocumentsContext")),
	ServiceLifetime.Transient);

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAchievementRepository, AchievementRepository>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

//---Swagger---//
//https://stackoverflow.com/questions/71932980/what-is-addendpointsapiexplorer-in-asp-net-core-6/71933535#71933535
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();

}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseDeveloperExceptionPage();
	app.UseMigrationsEndPoint();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
