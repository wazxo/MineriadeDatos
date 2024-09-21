using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
// Agregar servicios al contenedor
builder.Services.AddSingleton<SentimentService>();
var app = builder.Build();
// Configurar el pipeline de solicitud HTTP
app.UseAuthorization();
app.MapControllers();
app.Run();