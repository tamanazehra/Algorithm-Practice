Console.WriteLine("Enter the Number:" );
int input = Convert.ToInt32(Console.ReadLine());

int newInput;

if (input == 0)
{
    Console.WriteLine(1);
}
else
{
    newInput = Math.Abs(input);
    int counter = 0;

    while (newInput > 0)
    {
        newInput = newInput / 10;
        counter++;
    }

    Console.WriteLine("Number of digits: " + counter);
}
Console.ReadLine();
