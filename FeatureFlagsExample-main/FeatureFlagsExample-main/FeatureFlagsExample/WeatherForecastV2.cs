namespace FeatureFlagsExample;

public class WeatherForecastV2
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

    public string Region { get; set; }

    public string? Summary { get; set; }
}