//выводит таблицу квадратов чисел от 1 до N

//принимает данные
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//рисует таблицу
string Table(int x) //x - число столбцов
{
    string table = String.Empty; //пустая строка

    for (int i = 1; i <= x; i++)
    {
        Console.Write(i + "\t");
    }
    return table;
}

//рисует строку с числами
string Numbers(int x)
{
    string numbers = string.Empty;
    for (int i = 1; i <= x; i++)
    {
        Console.Write(Math.Pow(i, 3) + "\t");
    }
    return numbers;
}

int N = ReadData("Введите число N: ");
Console.WriteLine(Table(N));
Console.WriteLine(Numbers(N));