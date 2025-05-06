Console.WriteLine("Enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());

if (input == 0)
{
    Console.WriteLine("The number has 1 even digit.");
}
else
{
    input = Math.Abs(input);
    int count = 0;

    while (input > 0)
    {
        int digit = input % 10;
        if (digit % 2 == 0)
        {
            count++;
        }
        input /= 10;
    }
    Console.WriteLine($"The number has {count} even digits.");
}


