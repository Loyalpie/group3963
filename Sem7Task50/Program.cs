﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

//метод поиска существования числа в массиве по индексам
int SearchNumberInArray(int[,] array, int firstIndex, int secondIndex)
{
    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            if (i == firstIndex && j == secondIndex) return array[i,j];
        }
    }
    return -1;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array = Gen2DArray(row, column, 10, 99);
Print2DArray(array);

int firstIndex = ReadData("Введите первый индекс элемента: ");
int secondIndex = ReadData("Введите второй индекс элемента: ");

Console.WriteLine($"{SearchNumberInArray(array, firstIndex, secondIndex)}");