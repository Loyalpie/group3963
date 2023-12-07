// Принимает на вход число и возвращает сумму цифр этого числа

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод нахождения суммы цифр числа
int RecSumDigit(int num)
{
    if (num==0) return 0; //точка остановки рекурсии
    else return num % 10 + RecSumDigit(num / 10);
}

int number = ReadData("Введите число: ");
Console.WriteLine(RecSumDigit(number));