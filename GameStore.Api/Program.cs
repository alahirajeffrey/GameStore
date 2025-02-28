using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [ 
    new (
        1, 
        "Street Fighter II", 
        "Fighting",
        19.99M, 
        new DateOnly(2010,9,20)
    ),
    new (
        2, 
        "Final Fantacy", 
        "Roleplaying",
        59.99M, 
        new DateOnly(2010,9,30)
    ),
    new (
        3, 
        "FIFA 23",
        "Sports", 
        19.99M, 
        new DateOnly(2010,9,20)
    ), ];

// GET /games
app.MapGet("/games", () => games);

// GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id) );

app.Run();
