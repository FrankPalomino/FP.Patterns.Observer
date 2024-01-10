using FP.Patterns.Observer.Exercice2;

TemperatureSensor sensor = new TemperatureSensor();
TemperatureObserver obs1 = new TemperatureObserver("First observer");
TemperatureObserver obs2 = new TemperatureObserver("Second observer");

sensor.AddObserver(obs1);
sensor.AddObserver(obs2);

sensor.SetTemperature(100);
sensor.SetTemperature(120);
sensor.SetTemperature(150);

sensor.RemoveObserver(obs1);

sensor.SetTemperature(250);

