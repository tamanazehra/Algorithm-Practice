
//Find the Missing Number in a Sequence 
//You are given a sequence of N consecutive numbers from 1 to N, but one number is 
//missing. The numbers are given in a random order as a list. Your task is to determine the 
//missing number. 

//Input:
//N = 5
//arr = [1, 2, 4, 5]

//Output:
//3

using System;

class Program
{
    static void Main()
    {
        int[] arr = [1, 2, 4, 5];

        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] + 1 != arr[i + 1])
            {
                Console.WriteLine(arr[i] + 1);
                Console.ReadLine();
            }
        }
    }
}

