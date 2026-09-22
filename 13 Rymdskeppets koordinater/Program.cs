Console.Write("Y koordinat: ");
bool successY = int.TryParse(Console.ReadLine(), out int y);

Console.Write("X koordinat: ");
bool successX = int.TryParse(Console.ReadLine(), out int x);

while(!successX ||  !successY || y >= 6 || y <= 0|| x >= 6 || x <= 0)
{
    Console.WriteLine("Fel, måste vara siffror 1 - 5");

    Console.Write("X kordinator: ");
    successX = int.TryParse(Console.ReadLine(), out x);

    Console.Write("Y kordinator: ");
    successY = int.TryParse(Console.ReadLine(), out y);
}


for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= 5; j++)
    {

        if(y == i && x == j)
        {
            Console.Write("S");
        }
        else
        {
            Console.Write(".");
        }
        
    }

    Console.WriteLine();
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();