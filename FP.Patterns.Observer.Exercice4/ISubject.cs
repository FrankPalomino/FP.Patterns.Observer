namespace FP.Patterns.Observer.Exercice4
{
    public interface ISubject
    {
        void Attaching(IObserver observer);
        void Detaching(IObserver observer);
        void Notify();
    }
}
