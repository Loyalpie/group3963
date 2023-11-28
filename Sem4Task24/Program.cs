//принимает на вход число А и выдает сумму чисел от 1 до А

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//вывод данных
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

long SumGausse(long numA)
{
    return ((1 + numA) * numA) / 2;
}

//метод находит сумму
long SumSimple(long numA)
{
    long sum = 0;

    for (int i = 1; i <= numA; i++)
    {
        sum += i;
    }
    return sum;
}

int numberA = ReadData("Введите число А: ");

//вывод результата по простому методу
DateTime d1 = DateTime.Now; // счетчик времени. записываем текущее время
long result = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1); //находим разницу между началом выполнения операции и окончанием

//вывод по формуле Гаусса
DateTime d2 = DateTime.Now;
long result2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма числе от 1 до А равна (простой метод): " + result);
PrintResult("Сумма числе от 1 до А по формуле Гаусса равна: " + result2);