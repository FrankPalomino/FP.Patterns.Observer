namespace FP.Patterns.Observer.Exercice4
{
    public class StatisticsDisplay : IObserver
    {
        public void Update(int temperature, int humidity, int presure)
        {
            Console.WriteLine($"Statistics Display: \nTemperature: {temperature}º\nHumidity: {humidity}%\nPresure: {presure} Pa.");
        }
    }
}
