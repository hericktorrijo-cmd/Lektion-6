string[] fileNames = [".config", ".index.html", ".git", "styles.css", "Excel", "CSS"];

foreach (string fileName in fileNames)
{
    if (fileName.StartsWith("."))
        {
        continue;
        }

    Console.WriteLine(fileName);
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();