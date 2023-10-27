Console.WriteLine("-------Boxing / Unboxing-------");

// Create an empty List of type object
List <object>  values = new List<object>();
// Add the following values to the list: 7, 28, -1, true, "chair"
values.Add(7);
values.Add(28);
values.Add(-1);
values.Add(true);
values.Add("chair");

int sum=0;
// Loop through the list and print all values
foreach (object item in values)
{
    Console.WriteLine("these are all items in the list: " +item);
}
Console.WriteLine("-------------------------------");

foreach (object item in values){   
    // Add all values that are Int type together and output the sum
    if (item is int){
        Console.WriteLine("this is an int: "+item);
        int x = Convert.ToInt32(item);
        sum += x;
    }
}
Console.WriteLine("-------------------------------");
Console.WriteLine("this is the Sum of all int:"+sum);




