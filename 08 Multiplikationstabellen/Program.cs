for(int yttre = 1; yttre <= 5;  yttre++)
{
    
    for(int inre = 1; inre <=5; inre++)
    {
        Console.Write($"{inre * yttre,-4}");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("\n\nTryck på valfri knapp för att stänga konsolen...");
Console.ReadKey();