namespace FP.Patterns.Observer.Exercice4
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = [];
        private int _temperature;
        private int _humidity;
        private int _pressure;

        public void Attaching(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detaching(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void ChangeWeather(int temperature, int humidity, int pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Notify();
        }
    }
}
