
//? 1. Print 1-255

static void PrintNumbers()
{
    int i = 1;
    while (i <= 255)
    {
        Console.WriteLine(i);
        i+=1;
    }
};
PrintNumbers();
//? 2. Print odd numbers between 1-255

static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    int i = 1;
    while (i < 255)
    {
        if ( i %2 != 0){

        Console.WriteLine(i);
        }
        i = i + 1;
    }
};
PrintOdds();

//? 3. Print Sum

static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int i = 0;
    int sum=0;
    while (i < 255)
    {
        Console.WriteLine($"New Number :{i} Sum :{sum}");
        i+=1;
        sum= i+1;
    }
};
PrintSum();

//? 4. Iterating through an Array

static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console.

    foreach (int item in numbers){
        Console.WriteLine(item);
     }
};  
int[] numbers={1,2,6,5} ;   
LoopArray(numbers);

//? 5. Find Max

static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max= numbers[0];
    for (int i=0; i < numbers.Length;i++)
    {
        if(numbers[i]>max)
        {
            max=numbers[i];
        }
    }
    Console.WriteLine(max);
    return max;
    
}
int[] numbers = {1,2,3,4,6};
int[] numbers2 = {0, -3, -8 ,-7};

FindMax(numbers);
FindMax(numbers2);

//? 6. Get Average

static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int sum = 0;
    int count = numbers.Length;
    int avg =0;
    foreach (int item in numbers){   
    // Add all values that are Int type together and output the sum
    sum += item;
    avg = sum / count;
    }
    Console.WriteLine($"this is the AVERAGE of value in this array: {avg}");
}
int[] numbers = {2, 10 ,3};
int[] numbers2 = {-9, 10 ,1, - 20, 100};
GetAverage(numbers);
GetAverage(numbers2);


//? 7. List with Odd Numbers

static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    List <int>  values = new List<>(int);
    int i = 1;
    while (i < 255)
    {
        if( i%2 !=0)
        values.Add(i);
        Console.WriteLine(i);
        i+=1;
    }
   return values;
}
OddList();

//? 8. Greater than Y

static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int x =0;
    for (int i=0; i<numbers.Count;i++)
    {
        if ( numbers[i]>y)
        {
            x +=1;
            Console.WriteLine(numbers[i]);
        }
    }
    Console.WriteLine(x);
    return x;
}
List<int> numbers = new List<int>(){1,3,5,7};
GreaterThanY(numbers ,3);

//? 9. Square the Values

static void SquareArrayValues(List<int> numbers)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
   for (var i = 0; i < numbers.Count; i++)
    {
        numbers[i]=numbers[i]* numbers [i];
        Console.WriteLine(numbers[i]);
    }

}
List<int> numbers = new List<int>{1,5,10,-10};
SquareArrayValues(numbers);

//? 10. Eliminate Negative Numbers

static void EliminateNegatives(List<int> numbers)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    for (var i = 0; i<numbers.Count; i++)
    {
        if (numbers[i]<0)
        {
            numbers[i]=0;
        }
        Console.WriteLine(numbers[i]);
    }
}
List<int> numbers = new List<int>{1,5,10,-2};
EliminateNegatives(numbers);
