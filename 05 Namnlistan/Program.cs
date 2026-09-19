string[] names = { "Herick", "Chris", "Smiley", "Joker", "Chico" };

foreach  (string name in names)
{
    Console.WriteLine(name.ToUpper());
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();
