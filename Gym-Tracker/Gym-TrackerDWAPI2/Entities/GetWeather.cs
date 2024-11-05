using System.ComponentModel.DataAnnotations;

namespace Gym_TrackerDWAPI.Entities
{
    public class WeatherData
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Temp { get; set; }
        public float ChanceOfRain { get; set; }

        public WeatherData() { }

        public WeatherData(DateTime date, float temp, float chanceOfRain)
        {
            Date = date;
            Temp = temp;
            ChanceOfRain = chanceOfRain;
        }
    }
}
