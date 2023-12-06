//проверяет является ли одно число квадратом другого

string? numberOneLine = Console.ReadLine();
string? numberTwoLine = Console.ReadLine();

int numberOne = int.Parse(numberOneLine ?? "0");
int numberTwo = int.Parse(numberTwoLine ?? "0");
int x = 0;

if (numberOne > numberTwo)
{
    if (numberOne == numberTwo * numberTwo)
    {
        Console.WriteLine($"{numberOne} является квадратом числа {numberTwo}");
    }
    else
    {
        Console.WriteLine($"{numberOne} НЕ является квадратом числа {numberTwo}");
    }
}
else
{
    x = numberOne;
    numberOne = numberTwo;
    numberTwo = x;
    if (numberOne == numberTwo * numberTwo)
    {
        Console.WriteLine($"{numberOne} является квадратом числа {numberTwo}");
    }
    else
    {
        Console.WriteLine($"{numberOne} НЕ является квадратом числа {numberTwo}");
    }
}