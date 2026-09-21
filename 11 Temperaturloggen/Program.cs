double[] temperatures = { 23.4, 25.7, 28.9, 30.1, 22.0 };
double totalTemperature = 0;
double highestTemperature = temperatures[0];
double avarageTemperature = 0;
foreach (double temperature in temperatures)
{
    totalTemperature += temperature;

    if (temperature > highestTemperature)
    {
        highestTemperature = temperature;
    }


}

avarageTemperature = totalTemperature / temperatures.Length;

Console.WriteLine($"Medeltemperaturen är: {avarageTemperature:F1}");
Console.WriteLine($"Högsta temperaturen är: {highestTemperature:F1}");

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();