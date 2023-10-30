//? Random Array
// Required:
// Create a function called RandomArray() that returns an integer array
static int[] RadomArray()
{

    //* Create an empty array that will hold 10 integer values.
    int[]RArray = new int[10];
    //* Loop through the array and assign each index a random integer value between 5 and 25.
    Random rand = new Random();
    int max =0;
    int min =0;
    for(int i = 0; i < 10; i++)
    {
       RArray[i]=rand.Next(5,25);
    //* Print the min and max values of the array
     if(RArray[i]>max)
        {
            max=RArray[i];
        }
    //* Print the sum of all the values
    else
        {
            min=RArray[i];
        }
    Console.WriteLine(RArray[i]);    
    }
    Console.WriteLine($"This is the min Value of the array: {min}");
    Console.WriteLine($"This is the max Value of the array: {max}");
    return RArray;
}
RadomArray();

//? Coin Flip
// Required:
// Create a function called TossCoin() that returns a string
// static string TossCoin()
{

    //* Have the function print "Tossing a Coin!"
    Console.WriteLine("Tossing a Coin!");
    //* Randomize a coin toss with a result signaling either side of the coin
    Random rand = new Random();
    int y = rand.Next(0,2);
    string result;
    // Console.WriteLine(y);
    //* Have the function print either "Heads" or "Tails"
    if (y ==0)
    {
        result="Heads";
        Console.WriteLine("You got this");
    }
    else
    {
        result="Tails";
        Console.WriteLine("Better Luck next time!!");
    }
    //* Finally, return the result
    Console.WriteLine(result);
    return result;
}
TossCoin();

// Optional:

    //* Create another function called TossMultipleCoins(int num) that returns a Double
    //* Have the function call the tossCoin function multiple times based on num value
    // *Have the function return a Double that reflects the ratio of head toss to total toss

//? Names
// Build a function Names that returns a list of strings. In this function:
// Required:
static void Names(List<string> names){
    
    //* Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
    //* Return a list that only includes names longer than 5 characters
    foreach (string item in names){
        if (item.Length>5)
        {
            Console.WriteLine(item);
        }
    }
}
List<string> names = new List<string>{"Todd", "Tiffany", "Charlie" , "Geneva", "Sydney"};
Names(names);
// Optional:

    //* Shuffle the list and print the values in the new order