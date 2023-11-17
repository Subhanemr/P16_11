using _16_11.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>((options) => { options.UseSqlServer(builder.Configuration.GetConnectionString("Default")); });

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute( 
	"default",
	"{controller=home}/{action=index}"
	);

app.Run();
