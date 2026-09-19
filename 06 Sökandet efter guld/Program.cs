/*Skapa en array med strängar som representerar föremål i en ryggsäck 
 * (t.ex. 'Rep', 'Fackla', 'Guld',
'Karta', 'Kompass'). Använd en snurra för att söka efter 'Guld'. Så fort programmet
hittar guld ska
det skriva ut 'Guld hittat!' och omedelbart avbryta snurran med break.*/

string[] objects = { "Rep", "Fackla", "Guld", "Konserv-mat", "Karta", "Kompass" };

foreach (string obj in objects)

{
    Console.WriteLine(obj);
    if (obj == "Guld")
    {
        Console.WriteLine("Guld hittat!");
        break;
    }
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();
