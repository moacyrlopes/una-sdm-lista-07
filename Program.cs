var builder = WebApplication.CreateBuilder(args);

// 🔥 ADICIONA ISSO
builder.Services.AddControllers();

var app = builder.Build();

// 🔥 ADICIONA ISSO
app.MapControllers();

app.Run();