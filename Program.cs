//Question 1: Write an funciton that finds the largest and smallest numbers in an array 
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
//2a

//2b

//2c

//Question 3: Write a function that checks if 2 strings are anagrams.

//Question 4: Write a RegEx to match an Australian mobile phone

Console.WriteLine("Hello, World!");

//Question 1: Example
var result = FindMinMax(new[] { 123, 534, 3, 9, 275 });
Console.WriteLine($"Min: {result.min}, Max: {result.max}");


