using System;

namespace GameStore.Api.Entities;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int IdGenre { get; set; }
    public Genre? Genre { get; set; }
    public decimal Price { get; set; }
    public DateOnly ReleaseDate {get; set; }
}
