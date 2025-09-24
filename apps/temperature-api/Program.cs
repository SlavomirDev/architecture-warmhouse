var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddNewtonsoftJson();

var app = builder.Build();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.Run();
