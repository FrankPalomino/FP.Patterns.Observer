namespace FP.Patterns.Observer.Exercice1
{
    public class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set;}

        public List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void AddStock(int stock)
        {
            Stock += stock;
            Notify();
        }
    }
}
