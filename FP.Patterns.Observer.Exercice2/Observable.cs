namespace FP.Patterns.Observer.Exercice2
{
    public class Observable
    {
        private readonly List<IObserver> _observers;

        public Observable()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(float temperature)
        {
            foreach(var observer in _observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
