// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод перевода из 10 в 2 систему счисления
string Converse10to2(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

int number = ReadData("Введите число: ");
string newNumber = Converse10to2(number);
Console.WriteLine(newNumber);