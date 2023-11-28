//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//метод ввода данных
double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine());
}

//метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

double number = ReadData("Введите число N: ");
string numberLine = number.ToString();
int len = numberLine.Length;

int[] array = new int[len];

//суммирует элементы массива, в которых хранятся значения разрядов числа
int Result(double num)
{
    double newNum = 0;
    double numRem = 0;
    int count = 0;
    int i = len;
    while (count < len)
    {
        newNum = num / Math.Pow(10, (i - 1));
        array[count] = (int)newNum;
        numRem = num % Math.Pow(10, (i - 1));
        num = numRem;
        i -= 1;
        count += 1;
    }

    int index = 0;
    int result = 0; //сумма изначально равна 0
    for (int j = 0; j < len; j++)
    {
        result += array[index]; //прибавляем значение array[index]
        index += 1;
    }
    return result;
}

//находит сумму цифр, но только через строки
int ResultString(string numLine)
{
    int index = 0;
    int x = 0;
    int result = 0;
    string line = String.Empty; //пустая строка, в которую потом будут записываться цифры

    for (int i = 0; i < len; i++)
    {
        line = (numLine[i]).ToString();
        x = int.Parse(line);
        result += x;
        //index += 1;
    }
    return result;
}


DateTime time1 = DateTime.Now;
int result = Result(number);

DateTime time2 = DateTime.Now;
int result2 = ResultString(numberLine);

PrintData($"Сумма цифр числа {number} равна {result.ToString()} по числовому методу. Время {DateTime.Now - time1}");
PrintData($"Сумма цифр числа {number} равна {result2.ToString()} по строчному методу. Время {DateTime.Now - time2}");
