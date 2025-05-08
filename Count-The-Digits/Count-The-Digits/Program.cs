Console.WriteLine("Enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());

input = Math.Abs(input);

int[] digits = new int[10];

while (input > 0)
{
    int digit = input % 10;
    digits[digit]++;
    input /= 10;
}

for (int i = 0; i < digits.Length; i++)
{
    if (digits[i] > 0)
    {
        Console.WriteLine($"Digit {i} occurs {digits[i]} times.");
    }
}

