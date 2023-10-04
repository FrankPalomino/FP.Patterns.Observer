namespace FP.Patterns.Observer
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string message;
        private Random rnd = new Random();
        private int number;

        public int Number { get => number; set => number = value; }

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
                //observer.Update(message);
                observer.UpdatePull();
            }
        }

        public void Work()
        {
            number = rnd.Next(10);

            if (number % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("New valid number");
                message = string.Format("New valid number: {0}", number);
                Notify();
            }
        }
    }
}
