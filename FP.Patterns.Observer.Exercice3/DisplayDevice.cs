namespace FP.Patterns.Observer.Exercice3
{
    public class DisplayDevice : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"DisplayDevice: The temperature change to {temperature}ºC");
        }
    }
}
