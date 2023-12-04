//МАССИВ ИЗ 123 ЭЛЕМЕНТОВ. НАЙТИ КОЛ-ВО ЭЛЕМЕНТОВ В ОТРЕЗКЕ 10-99


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

//находит количество элементов в массиве
int QuantityNumbers(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

int minValue = ReadData("Введите минимальное значение: ");
int maxValue = ReadData("Введите максимальное значение: ");

int[] array = GenArray(123, -100, 100);
Print1DArray(array);
int count = QuantityNumbers(array, minValue, maxValue);

Console.WriteLine(count);