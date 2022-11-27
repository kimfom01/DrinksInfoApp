using System.Text.Json.Serialization;

namespace drinks_info_console.Models;

public class Drink
{
    [JsonPropertyName("idDrink")]
    public int Id { get; set; }
    [JsonPropertyName("strDrink")]
    public string? DrinkName { get; set; }
}