Console.WriteLine("Enter first string:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter second string:");
string input2 = Console.ReadLine();

if (input1.Length != input2.Length)
{
    Console.WriteLine("Not an anagram!");
}
else
{
    input1 = input1.ToLower();
    input2 = input2.ToLower();

    char[] inputArray1 = input1.ToCharArray();
    char[] inputArray2 = input2.ToCharArray();

    Array.Sort(inputArray1);
    Array.Sort(inputArray2);

    bool isAnagram = true;

    for (int i = 0; i < inputArray1.Length; i++)
    {
        if (inputArray1[i] != inputArray2[i])
        {
            isAnagram = false;
            break;
        }
    }

    if (isAnagram)
    {
        Console.WriteLine("It is an anagram!");
    }
    else
    {
        Console.WriteLine("It's not an anagram!");
    }

    Console.ReadLine();
}

