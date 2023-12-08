// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//рекурентная сумма чисел от m до n
int RecSumInRange(int m, int n)
{
    if (m >= n) { return n; }
    else return m + RecSumInRange(m + 1, n);
}

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");

Console.WriteLine(RecSumInRange(m, n));