// Задать 2-мерный массив из целых чисел. 
// Удалить строчку и столбец на пересечении которых находится наименьший элемент массива

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

//метод поиска значения минимального элемента массива
(int x, int y) SearchMinValue(int[,] array)
{
    int row = 0; //значение строки
    int column = 0; //значение столбца

    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}

//метод удаления строки и столбца, нак отором находится минимальное значение
int[,] DeleteStrAndColumn(int[,] array, int x, int y)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; //новый массив

    //новые счетчики для нового массива (он же меньше входящего...)
    int k = 0;
    int m = 0;

    for (int i = 0; i < array.GetLength(0); i++) // .GetLength(0) - длина первого измерения массива (строки)
    {
        m = 0;

        for (int j = 0; j < array.GetLength(1); j++) // .GetLength(1) - длина второго измерения массива (столбцы)
        {
            if (i != x && j != y) //чтобы не доавился элемент на удаляемой строке или столбце
            {
                newArray[k, m] = array[i, j];
            }
            if (j != y) m++;
        }
        if (i != x) k++;
    }
    return newArray;
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] array = Gen2DArray(row, column, 10, 99);
Print2DArray(array);

Console.WriteLine();

(int x, int y) minElem = SearchMinValue(array);
int[,] newArray = DeleteStrAndColumn(array, minElem.x, minElem.y);
Print2DArray(newArray);