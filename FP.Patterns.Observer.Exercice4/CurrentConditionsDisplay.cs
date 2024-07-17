namespace FP.Patterns.Observer.Exercice4
{
    public class CurrentConditionsDisplay : IObserver
    {
        public void Update(int temperature, int humidity, int presure)
        {
            Console.WriteLine($"Current Conditions: \nTemperature: {temperature}º\nHumidity: {humidity}%\nPresure: {presure} Pa.");
        }
    }
}
