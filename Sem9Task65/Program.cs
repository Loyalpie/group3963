// Задайте значения M и N. Найти все натуральные числа в промежутке от M до N

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод нахождения чисел от m до n с помощью рекурсии
void SearchNumbersInRange(int m, int n)
{
    Console.Write(m + " ");
    if (m >= n) { }
    else SearchNumbersInRange(m + 1, n);
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

SearchNumbersInRange(m, n);