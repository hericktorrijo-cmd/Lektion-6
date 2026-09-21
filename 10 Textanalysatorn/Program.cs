Console.WriteLine("Skriv en valfri text, vi ska beräkna antal mellanslag i meningen: ");
string userText = Console.ReadLine();

int spacebar = 0;

foreach (char letter in userText)
{
    if(letter == ' ')
    {
        spacebar++;
    }
}

Console.WriteLine($"Antal mellanslag: {spacebar}");

Console.WriteLine("\n\nTryck på valfri knapp för att stänga konsolen...");
Console.ReadKey();