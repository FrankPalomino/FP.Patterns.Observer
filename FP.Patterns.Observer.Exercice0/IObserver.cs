namespace FP.Patterns.Observer
{
    public interface IObserver
    {
        void Update(string message);
        void UpdatePull();
    }
}
