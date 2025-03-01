//Encode Repeating Characters
//You are given a string S consisting of lowercase English letters. Your task is to encode the string
//using the following rule:
//Consecutive repeating characters should be replaced with the character followed by the 
//count of its occurrences.
//If a character appears only once consecutively, it remains unchanged.
//The final encoded string should be returned.

//Input:
//S="aaabbcddd"
//Output:
//"a3b2cd3"

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(EncodeString("aaabbcddd"));

        Console.ReadLine();
    }

    private static string EncodeString(string str)
    {
        string result = "";
        int count = 1;

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
                count++;
            else
            {
                if (count > 1)
                    result += str[i] + count.ToString();
                else
                    result += str[i]; 

                count = 1;  

            }
        }

        //if (count > 1)
        //    result += str[^1] + count.ToString(); 
        //else
        //    result += str[^1].ToString();

        return result;
    }
}
