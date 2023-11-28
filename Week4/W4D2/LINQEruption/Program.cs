List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
//find the first eruption that is in Chile and print the result.
Eruption firstInChile = eruptions.Where(e => e.Location == "Chile").First();
Console.WriteLine($"First eruption in Chile: {firstInChile}");
//Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption HawaiianIs = eruptions.Where(e => e.Location =="Hawaiian Is").First();
if (HawaiianIs == null)
{
    System.Console.WriteLine("no Hawaiian Is Eruption found.");
}
else
{
    System.Console.WriteLine($"First eruption from the Hawaiian Is: {HawaiianIs}");
}
//Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> highElevations = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(highElevations, "Eruptions with elevation over 2000m:");

//Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> FirstWithL = eruptions.Where(e => e.Volcano.StartsWith("L"));
PrintEach(FirstWithL, "Eruptions with name starting with L:");

//Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
Eruption highestElevations = eruptions.Where(e => e.ElevationInMeters == eruptions.Max(e => e.ElevationInMeters)).First();
System.Console.WriteLine($"Highest elevation:{highestElevations.ElevationInMeters}");

//Use the highest elevation variable to find a print the name of the Volcano with that elevation.
System.Console.WriteLine($"Volcano with highest elevation: {highestElevations.Volcano}");

//Print all Volcano names alphabetically.
IEnumerable<Eruption> OrderByName = eruptions.OrderBy(v =>  v.Volcano);
PrintEach(OrderByName, "Eruptions ordered by name:");

//Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> OrderByBefore1000 = eruptions.OrderBy(v => v.Volcano).Where(v => v.Year < 1000);
PrintEach(OrderByBefore1000, "Eruptions ordered by Name before 1000CE:");


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}