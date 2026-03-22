//Question 1: Write an funciton that finds the largest and smallest numbers in an array 
using System.Text;
using System.Timers;

static (int min, int max) FindMinMax(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");

    int min = numbers[0];
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];

        if (numbers[i] > max)
            max = numbers[i];
    }

    return (min, max);
}
//Question 2: Write a function that removes duplicate characters from string. Provide at least 3 solutions.
//Which is best in your opinion? Why?
//2A
static string RemoveDuplicates_HashSet(string input)
{
    if (string.IsNullOrEmpty(input)) return input;
    var seen = new HashSet<char>();
    var result = new StringBuilder();
    foreach (char c in input)
    {
        // returns false if exists
        if (seen.Add(c)) 
        {
            result.Append(c);
        }
    }
    return result.ToString();
}
//2B
static string RemoveDuplicates_Linq(string input)
{
    if (string.IsNullOrEmpty(input)) return input;
    return new string(input.Distinct().ToArray());
}
//2C
static string RemoveDuplicates_NoExtraSpace(string input)
{
    if (string.IsNullOrEmpty(input)) return input;
    var result = new StringBuilder();
    for (int i = 0; i < input.Length; i++)
    {
        bool isDuplicate = false;
        for (int j = 0; j < i; j++)
        {
            if (input[i] == input[j])
            {
                isDuplicate = true;
                break;
            }
        }
        if (!isDuplicate)
        {
            result.Append(input[i]);
        }
    }
    return result.ToString();
}
//2a is best becuase O(n) time, Keeps original order, Clean and efficient

//Question 3: Write a function that checks if 2 strings are anagrams.

//Question 4: Write a RegEx to match an Australian mobile phone

Console.WriteLine("Hello, World!");

//Question 1: Example
var result = FindMinMax(new[] { 123, 534, 3, 9, 275 });
Console.WriteLine($"Min: {result.min}, Max: {result.max}");
//Question 2: Example
//2A
Console.WriteLine($"Input String for removing duplicate characters is 'Hello'");
var inputString = "hello";
var string1 = RemoveDuplicates_HashSet(inputString);
Console.WriteLine($"RemoveDuplicates_HashSet");
Console.WriteLine($"{string1}");
//2B
var string2 = RemoveDuplicates_Linq(inputString);
Console.WriteLine($"RemoveDuplicates_Linq");
Console.WriteLine($"{string2}");
//2C
var string3 = RemoveDuplicates_NoExtraSpace(inputString);
Console.WriteLine($"RemoveDuplicates_NoExtraSpace");
Console.WriteLine($"{string3}");



