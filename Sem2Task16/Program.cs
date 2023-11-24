string? numberOneLine = Console.ReadLine();
string? numberTwoLine = Console.ReadLine();

int numberOne = int.Parse(numberOneLine);
int numberTwo = int.Parse(numberTwoLine);
int x = 0;

if (numberOne > numberTwo)
{
    if (numberOne == numberTwo * numberTwo)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
else
{
    x = numberOne;
    numberOne = numberTwo;
    numberTwo = x;
    if (numberOne == numberTwo * numberTwo)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}