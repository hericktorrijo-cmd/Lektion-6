while(true)
{
    Console.WriteLine("Vill du fortsätta snurra, skriv ja/j");
    string keepLooping = Console.ReadLine().ToLower();

    if(keepLooping != "ja" &&  keepLooping != "j")
    {
        Console.WriteLine("Avslutar loopen!!!");
        break;
    }
    Console.WriteLine("Fortsätter snurra.........");

}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen....");
Console.ReadKey();
