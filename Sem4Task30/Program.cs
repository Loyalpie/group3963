//ВЫВОДИТ МАССИВ ИЗ 8 ЭЛЕМЕНТОВ ЗАПОЛНЕННЫЙ СЛУЧАЙНЫМИ 0 И 1

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод генерации массива
int[] GenArray(int number, int min, int max)
{
    Random random = new Random(); //генерация случайных чисел в массиве
    int[] array = new int[number]; //создание массива с number-количеством элементов

    //заполнение массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); //заполнение случайными числами от min до max
    }
    return array; //возвращение массива
}

//метод вывода одномерного массива
void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int length = ReadData("Введите количество элементов массива: ");
int min = ReadData("Введите минимальное значение ячейки массива: ");
int max = ReadData("Введите максимальное значение ячейки массива: ");

Print1DArray(GenArray(length, min, max));