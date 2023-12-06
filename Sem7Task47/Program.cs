﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. *При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод генерации двумерного массива
double[,] Gen2DArray(int countRow, int countColumn, int min, int max) //кол-во строк, кол-во столбцов, минимум и максимум
{
    //корректировка входных данных (если минимум больше максимума)
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }

    Random random = new Random(); //генерация случайных чисел в массиве
    double[,] array = new double[countRow, countColumn]; //создание массива с number-количеством элементов

    //заполнение массива
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = random.Next(min, max + 1) + Math.Round(random.NextDouble(), 1); //заполнение случайными числами от min до max
        }
    }
    return array; //возвращение массива
}

//метод "рисования" двумерного массива
void Print2DArray(double[,] array)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                            ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                            ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                            ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                            ConsoleColor.Yellow};

    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)]; // покраска элементов массива в рандомный цвет
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
double[,] array = Gen2DArray(row, column, 10, 99);
Print2DArray(array);