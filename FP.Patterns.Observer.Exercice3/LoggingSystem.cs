namespace FP.Patterns.Observer.Exercice3
{
    public class LoggingSystem : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"LoggingSystem: The temperature change to {temperature}ºC");
        }
    }
}
