using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercise11ConvertSpeedUnits
{
    static void Main(string[] args)
    {
        int distanceInMeters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());
        float convertedInSeconds = (hours * 60f * 60f) + (minutes * 60f) + seconds;
        float convertedInHours = hours + (minutes / 60f) + (seconds / (60f * 60f));
        float distanceInKm = distanceInMeters / 1000f;
        float distanceInMiles = distanceInMeters / 1609f;
        float speedInMeterSeconds = distanceInMeters / convertedInSeconds;
        float speedInKmHour = distanceInKm / convertedInHours;
        float speedInMilesHour = distanceInMiles / convertedInHours;
        Console.WriteLine($"{speedInMeterSeconds}\n{speedInKmHour}\n{speedInMilesHour}");
    }
}