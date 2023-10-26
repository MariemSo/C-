// Challenge 1
bool amProgrammer = true; //* "true" was a string deleted the "" in order for it to  be boolean
int age = 27; //* age was 27.9 which is not an integer  
List<string> names = new List<string>();
names.Add("Monica"); //* names="Monica" syntax to add a string to the list was wrong
Dictionary<string, string> myDictionary = new Dictionary<string, string>();
myDictionary.Add("Hello", "0");
myDictionary.Add("Hi there", "0"); //* we declared the dictionary to be a string , the 0 was declered as an int which had to change to a string
// This is a tricky one! Hint: look up what a char is in C#
string myName = "MyName"; //* changed '' to ""
Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = 0; i <= Numbers.Count; i++) //*Index was out of range. Must be non-negative and less than the size of the collection / cs:line 15
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> moreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in moreNumbers)
{
    Console.WriteLine(moreNumbers);
}
// Challenge 4
List<int> evenMoreNumbers = new List<int> {3,6,9,12,14};
for (int num=0 ; num< evenMoreNumbers.Count; num++)
{
    if(evenMoreNumbers[num] % 3 == 0)
    {
        Console.WriteLine(evenMoreNumbers[num]);
    }
}
// Challenge 5
// What can we learn from this error message?
// string MyString = "superduberawesome";
// MyString[7] = "p";

// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}

