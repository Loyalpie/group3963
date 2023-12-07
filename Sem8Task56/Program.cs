// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

//метод "рисования" одномерного массива
void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}


int StringWithSmallSum(int[,] array)
{
    int[] array1D = new int[array.GetLength(1)]; //в этот массив будем сохранять суммы каждой строки входящего массива
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0; //после каждой новой строки сбрасываем счетчик

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            array1D[i] = sum;
        }
    }
    Print1DArray(array1D);

    int minSum = array1D[0];
    int index = 0; //сюда сохраняем индекс суммы

    //нахождение минимальной суммы в массиве сумм
    for (int i = 1; i < array1D.Length; i++)
    {
        if (array1D[i] < minSum) 
        {
            minSum = array1D[i];
            index = i;
        }
    }
    return index + 1;
}

int row = ReadData("Введите количество строк/столбцов: ");

int[,] array = Gen2DArray(row, row, 1, 9);
Print2DArray(array);
Console.WriteLine($"Строка с наименьшей суммой: {StringWithSmallSum(array)}");