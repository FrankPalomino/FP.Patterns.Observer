namespace FP.Patterns.Observer
{
    public class Observer : IObserver
    {
        private string _name;
        private Subject _subject;

        public Observer(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
            subject.Subscribe(this);
        }
        public void Update(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} received message: {1}", _name, message);
        }

        public void UpdatePull()
        {
            int number = _subject.Number;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} received number: {1}", _name, number);
        }
    }
}
