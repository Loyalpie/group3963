string? firstNumLine = Console.ReadLine();
string? secondNumLine = Console.ReadLine();

int firstNumber = int.Parse(firstNumLine);
int secondNumber = int.Parse(secondNumLine);
int x = 0;

if (firstNumber > secondNumber)
{
    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

else
{
    x = firstNumber;
    firstNumber = secondNumber;
    secondNumber = x;
    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}