// Задать значение N. Вывод всех натуральных чисел от N до 1
// с помощью рекурсии

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void LineGenRec(int num)
{
    Console.Write(num + " ");
    if (num == 1)
    {
        //ниче не делаем...
    }
    else LineGenRec(num - 1);
}

int number = ReadData("Введите число N: ");
LineGenRec(number);