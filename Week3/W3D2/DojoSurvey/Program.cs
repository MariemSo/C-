var builder = WebApplication.CreateBuilder(args);

//* Step 1
//Add server to the container
builder.Services.AddControllersWithViews();
var app = builder.Build();

//*Step2
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//*Step 3
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();