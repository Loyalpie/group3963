// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода всех чисел от 1 до N
void PrintNumsInRange(int n, int number)
{
    Console.Write(number + " ");
    number++;

    if (number <= n) PrintNumsInRange(n, number);
    else { }
}

int n = ReadData("Введите N: ");

PrintNumsInRange(n, 1);