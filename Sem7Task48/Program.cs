// Задать двумерный массив размер m*n, каждый элемент в массиве находится по формуле a(m, n) = m+n

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод генерации двумерного массива
int[,] Gen2DArrayMod(int countRow, int countColumn) //кол-во строк, кол-во столбцов, минимум и максимум
{
    int[,] array = new int[countRow, countColumn]; //создание массива

    //заполнение массива
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = i + j; //каждый элемент в массиве находится по формуле a(m, n) = m+n
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

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Gen2DArrayMod(row, column);
Print2DArray(array);