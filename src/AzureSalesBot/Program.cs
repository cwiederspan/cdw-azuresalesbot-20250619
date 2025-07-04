var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseRouting();
// app.UseAuthorization();
app.MapRazorPages();
app.Run();
