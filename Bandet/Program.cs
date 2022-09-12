var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
