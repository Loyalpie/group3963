// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод генерации двумерного массива
int[,] Gen2DArray(int countRow, int countColumn, int min, int max) //кол-во строк, кол-во столбцов, минимум и максимум
{
    //корректировка входных данных (если минимум больше максимума)
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }

    Random random = new Random(); //генерация случайных чисел в массиве
    int[,] array = new int[countRow, countColumn]; //создание массива с number-количеством элементов

    //заполнение массива
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = random.Next(min, max + 1); //заполнение случайными числами от min до max
        }
    }
    return array; //возвращение массива
}

//метод "рисования" двумерного массива
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//произведение двух матриц
int[,] ResultMatrix(int[,] array1, int[,] array2)
{
    int[,] resultMatrix = new int[array1.GetLength(0), array1.GetLength(1)]; //результирующая матрица

    for (int i = 0; i < array1.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array1.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            resultMatrix[i,j] = array1[i,j] *array2[i,j];
        }
    }
    return resultMatrix;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array1 = Gen2DArray(row, column, 1, 9);
int[,] array2 = Gen2DArray(row, column, 1, 9);

Print2DArray(array1);
Console.WriteLine();
Print2DArray(array2);

int[,] resultMatrix = ResultMatrix(array1,array2);

Console.WriteLine();
Print2DArray(resultMatrix);