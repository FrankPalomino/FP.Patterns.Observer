using FP.Patterns.Observer.Exercice4;

WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
ForecastDisplay forecastDisplay = new ForecastDisplay();

weatherData.Attaching(currentConditionsDisplay);
weatherData.Attaching(statisticsDisplay);
weatherData.Attaching(forecastDisplay);

weatherData.ChangeWeather(30, 18, 40);