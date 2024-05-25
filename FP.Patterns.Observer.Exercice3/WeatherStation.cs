namespace FP.Patterns.Observer.Exercice3
{
    public class WeatherStation
    {
        private readonly List<IObserver> _subs;
        private int _temperature;

        public WeatherStation()
        {
            _subs = new List<IObserver>();
        }

        public void RegisterSub(IObserver sub)
        {
            _subs.Add(sub);
        }

        public void DeregisterSub(IObserver sub)
        {
            _subs.Remove(sub);
        }

        public void WeatherChange(int temperature)
        {
            _temperature = temperature;
            NotifySubs();
        }

        private void NotifySubs()
        {
            foreach(var sub in _subs)
            {
                sub.Update(_temperature);
            }
        }
    }
}
