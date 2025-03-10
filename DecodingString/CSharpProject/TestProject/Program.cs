//Decode Encoded Characters 
//You are given an encoded string S that follows a specific encoding rule: 
//• A character followed by a number N represents that the character appears N times 
//consecutively. 
//• If a character is not followed by a number, it appears only once. 
//• Your task is to decode the string and return the original version before encoding.  
//Input:
//S = "a3b2cd3"
//Output:
//"aaabbcddd"


using System;

class Program
{
    static void Main(string[] args)
    {
        string S = "a3b2cd3";
        string character = "";
        string output = "";

        foreach (char ch in S)
        {
            if (ch >= '0' && ch <= '9')
            {
                int Count = int.Parse(ch.ToString());

                for (int i = 0; i < Count - 1; i++)
                {
                    output += character;
                }
            }
            else
            {
                output += character;
                character = ch.ToString();
            }
        }

        output += character;

        Console.WriteLine(output);
        Console.ReadLine();
    }
}