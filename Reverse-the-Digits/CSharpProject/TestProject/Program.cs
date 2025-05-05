Console.WriteLine("Enter your Input: ");

int number = Convert.ToInt32(Console.ReadLine());

int sign;

if (number < 0)
{
   number = Math.Abs(number);
   sign = -1;
}
else
{
    sign = 1;
}

int reverse = 0;

while (number > 0)
{
    int digit = number % 10;
    reverse = reverse * 10 + digit;
    number =number / 10;
}

reverse = sign * reverse;

Console.WriteLine("Reversed Number: " + reverse);
Console.ReadLine();









