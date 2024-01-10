namespace FP.Patterns.Observer.Exercice2
{
    internal class TemperatureObserver : IObserver
    {
        private readonly string _observerName;

        public TemperatureObserver(string name)
        {
            _observerName = name;
        }
        public void Update(float temperature)
        {
            Console.WriteLine($"Observer {_observerName} received an update. New Temperature is {temperature}");
        }
    }
}
