// See https://aka.ms/new-console-template for more information

//Write a C# Sharp program to compute the sum of the two numerical values. 
//If the two values are the same, return triple their sum.

//Sample Input:
//1, 2
//3, 2
//2, 2
//Expected Output:
//3
//5
//12

int a = 2;
int b = 2;
int c;
int d;

if (a != b)
{
    c = a + b;
    Console.WriteLine(c);
}
else
{
    c = a + b;
    d = c * 3;
    Console.WriteLine(d);
}

Console.ReadLine();
