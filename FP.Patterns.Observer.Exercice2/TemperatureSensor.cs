namespace FP.Patterns.Observer.Exercice2
{
    public class TemperatureSensor : Observable
    {
        private float _temperature;
        public float GetTemperature()
        {
            return _temperature;
        }
        
        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"Temperature: {temperature}");

            NotifyObservers(temperature);
        }
    }
}
