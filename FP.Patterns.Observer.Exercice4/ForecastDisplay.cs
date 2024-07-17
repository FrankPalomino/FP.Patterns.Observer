namespace FP.Patterns.Observer.Exercice4
{
    public class ForecastDisplay : IObserver
    {
        public void Update(int temperature, int humidity, int presure)
        {
            Console.WriteLine($"Forecast Display: \nTemperature: {temperature}º\nHumidity: {humidity}%\nPresure: {presure} Pa.");
        }
    }
}
