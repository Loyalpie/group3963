//Вывести первые N строк треугольника Паскаля 

//         1
//        1 1
//       1 2 1
//      1 3 3 1
//     1 4 6 4 1

//   n!/k!*(n-k)!
//Сделать вывод в виде равнобедренного треугольника

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


//метод создания факториала
long Factorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

//метод рисования треугольника Паскаля
void PrintPascalTriangle(int row)
{
    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < row - i; k++) Console.Write(" "); // рисование пробелов, чтобы треугольник был красивым и равнобедренным))

        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }
}

int Row = ReadData("Введите количество строк в треугольнике Паскаля: ");
PrintPascalTriangle(Row);