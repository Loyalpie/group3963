// Задать двумерный массив. Заменить строки на столбцы. Если это невозможно - вывести собщение 

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

//метод замены строк на столбцы в массиве
void ReplaceStrToColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = i + 1; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

// САМА ПРОГРАММА
if (row == column) // проверка на длину строк и столбцов
{
    int[,] array = Gen2DArray(row, column, 10, 99);
    Print2DArray(array);

    Console.WriteLine(); //пустая строка

    ReplaceStrToColumn(array);
    Print2DArray(array);
}
else Console.WriteLine("Невозможно поменять строки и столбцы...");