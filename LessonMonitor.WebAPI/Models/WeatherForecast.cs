using LessonMonitor.WebAPI.Attributes;
using System;

namespace LessonMonitor.WebAPI.Models
{
    [Description("Description for class WeatherForecast")]
    public class WeatherForecast
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int TemperatureC { get; set; }

        [Required]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required]
        public string Summary { get; set; }
    }
}
