//СЧИТАЕМ ПРОИЗВЕДЕНИЕ ЧИСЕЛ ОТ 1 ДО N (ФАКТОРИАЛ)

//подключая эту библиотеку можно использовать BigInteger - переменная с огромным числом
using System.Numerics; //так как факториал - быстрорастущая функция,то очень быстро число станет огрмным и в int не хватит памяти его записать (максимум N^15)

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод нахождения факториала
BigInteger Factorial(int number)
{
    BigInteger result = 1;
    for (int i = 2; i <= number; i++) result *= i;
    return result;
}

//вывод данных
void PrintResult(BigInteger result)
{
    Console.WriteLine(result);
}

int N = ReadData("Введите число N: ");
BigInteger result = Factorial(N);
PrintResult(result);