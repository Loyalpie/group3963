// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод генерации двумерного массива
int[,,] Gen3DArray(int x, int y, int z, int min, int max) //кол-во строк, кол-во столбцов, минимум и максимум
{
    //корректировка входных данных (если минимум больше максимума)
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }

    Random random = new Random(); //генерация случайных чисел в массиве
    int[,,] array = new int[x, y, z]; //создание массива с number-количеством элементов

    //заполнение массива
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = random.Next(min, max + 1); //заполнение случайными числами от min до max
            }
        }
    }
    return array; //возвращение массива
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            for (int k = 0; k < array.GetLength(2); k++) // .GetLength(2) - длина третьего измерения массива (столбцы)
            {
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

int x = ReadData("Введите x: ");
int y = ReadData("Введите y: ");
int z = ReadData("Введите z: ");

int[,,] array3D = Gen3DArray(x, y, z, 10, 99);
Print3DArray(array3D);