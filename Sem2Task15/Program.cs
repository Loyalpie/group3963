Console.WriteLine("Введите номер дня недели: ");
string? numberLine = Console.ReadLine();
int num = int.Parse(numberLine);

if (num > 0 && num < 8)
{
    if (num < 6)
    {
        Console.WriteLine("Это будний день");
    }
    else
    {
        Console.WriteLine("Это выходной");
    }
}
else
{
    Console.WriteLine("Неверный номер дня ненели...");
}