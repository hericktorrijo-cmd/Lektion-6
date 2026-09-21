Console.Write("Skriv in ett heltal: ");

int intNumber;

while (!int.TryParse(Console.ReadLine(), out intNumber))
{
    Console.WriteLine("FEL! Försök igen");
    Console.WriteLine("Skriv in ett heltal: ");
}
Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();