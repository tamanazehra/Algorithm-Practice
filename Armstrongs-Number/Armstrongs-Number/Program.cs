Console.WriteLine("Enter a number: ");
int input = int.Parse(Console.ReadLine());

int originalNumber = input;
Math.Abs(input);

int count = 0;
int temp = input;

while (temp > 0)
{
    temp /= 10;
    count++;
}

int sum = 0;
temp = input;
while (temp > 0)
{
    int digit = temp % 10;
    sum += (int)Math.Pow(digit, count);
    temp /= 10;
}

if (sum == originalNumber)
{
    Console.WriteLine($"{originalNumber} is an Armstrong number.");
}
else
{
    Console.WriteLine($"{originalNumber} is not an Armstrong number.");
}
    Console.ReadLine();



