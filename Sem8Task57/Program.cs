// Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз элемент встречается во входных данных

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

//метод создания частотного словаря
int[] Dictionary(int[,] array, int max)
{
    int[] dictionary = new int[max + 1];

    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            dictionary[array[i, j]]++;
        }
    }
    return dictionary;
}

// //метод рисования частотного словаря
// void PrintDictionary(int[] dictionary, int min)
// {
//     for (int k = min; k < dictionary.Length; k++)
//     {
//         Console.WriteLine($"Элементов {k}: {dictionary[k]}");
//     }
// }

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array = Gen2DArray(row, column, 0, 9);
Print2DArray(array);

int[] dictionary = Dictionary(array, 10);
Print1DArray(dictionary);