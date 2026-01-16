using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// מאפשר גישה מה-Frontend שלך
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader()
);

// בדיקת חיים
app.MapGet("/", () => "FansGame Backend is running");

// נתוני שחקן (דמו)
app.MapGet("/api/player", () =>
{
    return Results.Json(new
    {
        id = "NU-000001",
        name = "Player",
        level = 1,
        trophies = 110,
        coins = 75,
        gems = 2
    });
});

app.Run();
