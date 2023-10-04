using FP.Patterns.Observer;

Subject subject = new Subject();
Observer observer1 = new Observer("Observer 1", subject);
Observer observer2 = new Observer("Observer 2", subject);
Observer observer3 = new Observer("Observer 3", subject);

for (int i = 0; i < 5; i++)
{
    subject.Work();
}

subject.Unsubscribe(observer2);
Console.WriteLine("------Observer 2 unsubscribed-------");

for (int i = 0; i < 5; i++)
{
    subject.Work();
}