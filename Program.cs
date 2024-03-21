var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews() // Support for MVC
    .AddXmlSerializerFormatters();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<SaferWatchService>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Saferwatch V1");
    });
}
app.UseHttpsRedirection();
app.UseStaticFiles(); // Necessary for serving static files (e.g., CSS, JS, images)
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
