Console.WriteLine("Enter the Number: ");
int input = Convert.ToInt32(Console.ReadLine());



int newInput = Math.Abs(input);

int reverse = 0;

while (input > 0)
{
    int digit = input % 10;
    reverse = reverse * 10 + digit;
    input = input / 10;
}

if (newInput == reverse)
{
    Console.WriteLine("The number is a palindrome.");
}
else
{
    Console.WriteLine("The number is not a palindrome.");
}
Console.ReadLine();


