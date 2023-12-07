// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

//сортировка методом пузырька (самый маленький элемент поднимается наверх)
void BubbleSort(int[] array)
{
    for (int j = 1; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
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

//метод упорядочивает числа в строке по убыванию
void SortDescendingOrder(int[,] array)
{
    int[] array1D = new int[array.GetLength(1)];
    int[,] sortArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        //создаем ОДНОМЕРНЫЙ массив в который будем сохранять все элементы j строки
        for (int i = 0; i < array.GetLength(1); i++)
        {
            array1D[i] = array[j, i];
        }
        
        BubbleSort(array1D); //сортируем новый ОДНОМЕРНЫЙ массив

        //заполняем j строку нового ДВУМЕРНОГО массива
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sortArray[j, i] = array1D[i];
        }
    }

    //замена значений ИСХОДНОГО массива значениями из отсортированного массива
    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            array[i,j] = sortArray[i,j];
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array = Gen2DArray(row, column, 10, 99);
Print2DArray(array);

Console.WriteLine();
SortDescendingOrder(array);
Print2DArray(array);