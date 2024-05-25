namespace FP.Patterns.Observer.Exercice3
{
    public class MobileApp : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"MobileApp: The temperature change to {temperature}ºC");
        }
    }
}
