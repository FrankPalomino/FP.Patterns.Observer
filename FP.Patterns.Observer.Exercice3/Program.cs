using FP.Patterns.Observer.Exercice3;

//Station
WeatherStation weatherStation = new WeatherStation();

//Observers
DisplayDevice displayDevice = new DisplayDevice();
LoggingSystem log = new LoggingSystem();
MobileApp mobileApp = new MobileApp();

//Subcribe observers to Station
weatherStation.RegisterSub(displayDevice);
weatherStation.RegisterSub(mobileApp);
weatherStation.RegisterSub(log);

//Make temperature changes
Console.WriteLine("The temperature is up...");
Thread.Sleep(2000);
weatherStation.WeatherChange(20);
Console.WriteLine("The temperature is up...");
Thread.Sleep(2000);
weatherStation.WeatherChange(25);
Console.WriteLine("The temperature is up...");
Thread.Sleep(2000);
weatherStation.WeatherChange(30);