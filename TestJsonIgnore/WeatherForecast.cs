using System.Text.Json.Serialization;

namespace TestJsonIgnore
{
    public record WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

    }

    public record WeatherForecastWithInternalData : WeatherForecast
    {
        [JsonIgnore]
        public required string TextToIgnore { get; init; }

    }

    public record WeatherForecastWithInternalDataOptional : WeatherForecast
    {
        [JsonIgnore]
        public string? TextToIgnore { get; init; }

    }
}