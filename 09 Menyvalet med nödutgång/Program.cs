

while (true)
{
    Console.WriteLine("1: Visa profil");
    Console.WriteLine("2: Ändra inställningar");
    Console.WriteLine("3: Avsluta");
    
    string userChoice = Console.ReadLine();

    if(userChoice == "3")
    {
        break;
    }
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();