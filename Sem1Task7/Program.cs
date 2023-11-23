string? numLine = Console.ReadLine();
int num = int.Parse(numLine);
if (num > 99 && num < 1000)
{
    Console.WriteLine("Последняя цифра числа - " + num % 10);
}
else
Console.WriteLine("Введено неправильное число");