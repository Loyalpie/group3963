// задать 2-мерный массив, поменять 1 и последнюю строчку массива

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

//метод меняет местами первую и последнюю строчку массива
void ReplaceStrInArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
    {
        (array[0, j], array[array.GetLength(0) - 1, j]) = (array[array.GetLength(0) - 1, j], array[0, j]);
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array = Gen2DArray(row, column, 10, 99);
Print2DArray(array);

Console.WriteLine();

ReplaceStrInArray(array);
Print2DArray(array);