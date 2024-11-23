namespace GameStore.Api.Dtos;

public record class GameDto(
    int Id,
    string Name,
    string genre,
    decimal Price,
    DateOnly ReseleDate);
