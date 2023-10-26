// ?Three Basic Arrays

// Create an array to hold integer values 0 through 9
int[] array = new int[] {0,1,2,4,5,6,7,8,9};

// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
string[] array1 = new string[] {"Tim", "Martin", "Nikki", "Sara"};

// Create an array of length 10 that alternates between true and false values, starting with true
bool[] arr2= new bool[10];
        arr2[0]=true;
        for(int i=1;i < arr2.Length;i++){
            arr2[i]=!arr2[i-1];
        }
        for(int i=0;i < arr2.Length;i++){
           
          Console.WriteLine(arr2[i]);
        }

//? List of Flavors
// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
List<string> iceFlavor = new List<string>{"Oreo","Lemon","Strawberry","Vanilla","Choclate"};

// Output the length of this list after building it
Console.WriteLine($"Thoes are the current Flavor available {iceFlavor.Count}");

// Output the third flavor in the list, then remove this value
Console.WriteLine(iceFlavor[3]);
iceFlavor.RemoveAt(3);

// Output the new length of the list (It should just be one fewer!)
Console.WriteLine($"Thoes are the current Flavor available {iceFlavor.Count}");

//? User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
Dictionary<string,string> names = new Dictionary<string, string>();

// Add key/value pairs to this dictionary where:
// each key is a name from your names array
for (int j=0 ; j<4; j++){
        string name =array1[j];
        Console.WriteLine(name);
        Random rand = new Random();
        int randomindex = rand.Next(0,4);
        string randomFlavor=iceFlavor[randomindex];
        Console.WriteLine(randomFlavor);
        names.Add(name, randomFlavor);
}
// each value is a randomly selected flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor
//The var keyword takes the place of a type in type-inference
foreach (var entry in names)
{
        Console.WriteLine(entry.Key + " - " + entry.Value);
}


