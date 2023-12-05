// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


string FibNum(int number)
{
    string result = "0 1 "; //первые два числа Фибоначчи
    int first = 0;
    int last = 1;
    for (int i = 2; i < number; i++)
    {
        result += first + last + " ".ToString();
        (first, last) = (last, first + last);
    }
    return result;
}

int N = ReadData("Введите число N: ");
Console.WriteLine($"Первые {N} чисел Фибоначчи: {FibNum(N)}");