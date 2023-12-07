// принимает числа A и B. возводит A в степень B с помощью рекурсии

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод возведения в степень рекурсией
long PowNum(int a, int b)
{
    if (b <= 1) return a;
    else return a * PowNum(a, b - 1);
}

int a = ReadData("Введите A: ");
int b = ReadData("Введите B: ");
Console.WriteLine($"{a} в степени {b} = {PowNum(a, b)}");