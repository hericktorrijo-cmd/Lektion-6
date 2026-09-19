string correctPass = "hemligt123";

string userAnswer;

do
{
    Console.Write("Skriv in lösenord: ");
    userAnswer = Console.ReadLine();

    if (userAnswer != correctPass)
    {
        Console.WriteLine("Fel lösenord, försök igen...");
        userAnswer = Console.ReadLine();

    }

}
while (userAnswer != correctPass);

Console.WriteLine("Korrekt lösenord! Välkommen!");

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();
