//принимает на вход N и выдает таблицу квадратов от 1 до N

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//рисует верхнюю таблицу (шапку) от 1 до N
string Table(int x)
{
    string table = string.Empty;
    for (int i = 1; i <= x; i++)
    {
        table = table + i + "\t";
    }
    return table;
}

//метод расчета квадратов от 1 до N
string Calculator(int x, int y) //x - число, до которого возводим в степень (от 1 до N); y - степень, в которую возводим
{
    string result = String.Empty; // переменная result будет выводить результат. изначально пустая

    for (int i = 1; i <= x; i++)
    {
        result = result + Math.Pow(i, y) + "\t";
    }
    return result;
}

//ввод данных
int N = ReadData("Введите число N: "); 
int power = ReadData("Введите значение степени: ");

//рисуем таблицу
Console.WriteLine(Table(N));
Console.WriteLine(Calculator(N, power));