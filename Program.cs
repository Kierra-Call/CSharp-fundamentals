// 1. Iterate and print values
//Given a List of strings, iterate through the List and print out all the values. Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)

using System.ComponentModel;
using System.Globalization;

static void PrintList(List<string> MyList)
{
    MyList.ForEach(Console.WriteLine);
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

//2. Print Sum
//Given a List of integers, calculate and print the sum of the values.

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int number in IntList)
    {
        sum += number;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);

//3. Find Max
//Given a List of integers, find and return the largest value in the List.

static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int number in IntList)
    {
        if (number > max) 
        {
            max = number;
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

//4. Square the Values
//Given a List of integers, return the List with all the values squared.

static List<int> SquareValues(List<int> IntList)
{
    List<int> results = new List<int>();
    for (int i = 0; i < IntList.Count;i++)
    {
        results.Add(IntList[i] * IntList[i]);
        Console.Write($"{results[i]}, ");
    }
    return results;

}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

//5. Replace Negative Numbers with 0
//Given an array of integers, return the array with all values below 0 replaced with 0.

static int[] NonNegatives(int[] IntArray)
{
    int[] results = new int[IntArray.Length];
    for (int i = 0; i < IntArray.Length;i++)
    {
        if (IntArray[i] < 0)
        {
            results[i] = 0;
        } else {
            results[i] = IntArray[i];
        }
        Console.WriteLine($"results at i is: {results[i]}");
    }
    return results;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);

//6. Print Dictionary
//Given a dictionary, print the contents of the said dictionary.

static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(KeyValuePair<string, string> pair in MyDictionary)
    {
        Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}"); 
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//7. Find Key
//Given a search term, return true or false whether the given term is a key in a dictionary. (Hint: figuring this one out may require some research!)

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool found = false;
    foreach(KeyValuePair<string, string> pair in MyDictionary)
    {
        if (pair.Key == SearchTerm)
        {
            found = true;
        } 
    }
    return found;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


//8. Generate a Dictionary
//Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> names, List<int> numbers)
{
    Dictionary<string, int> results = new Dictionary<string,int>();
    for (int i = 0; i < names.Count; i++)
    {
        results.Add(names[i], numbers[i]);
    }
    foreach(KeyValuePair<string, int> pair in results)
    {
        Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}"); 
    }
    return results;
}
List<string> names = new List<string>();
names.Add("Julie");
names.Add("Harold");
names.Add("James");
names.Add("Monica");
List<int> numbers = new List<int>();
numbers.Add(4);
numbers.Add(3);
numbers.Add(7);
numbers.Add(9);
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
GenerateDictionary(names, numbers);













