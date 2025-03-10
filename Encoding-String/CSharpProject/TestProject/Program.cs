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

    private static string EncodeString(string S)
    {
        string result = "";
        int count = 1;

        for (int i = 0; i < S.Length - 1; i++)
        {
            if (S[i] == S[i + 1])
                count++;
            else
            {
                if (count > 1)
                    result += S[i] + count.ToString();
                else
                    result += S[i];

                count = 1;
            }
        }

        if (count > 1)
            result += S[S.Length - 1] + count.ToString();
        else
            result += S[S.Length - 1].ToString();

        return result;
    }
}
