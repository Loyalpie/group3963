// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

// метод подсчета количества четных чисел в массиве
int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0) count++;
    return count;
}

//сортировка методом пузырька (самый большой элемент поднимается наверх)
void BubbleSort(int[] array)
{
    for (int j = 1; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

//сортировка методом подсчета 
void CountSort(int[] array)
{
    int max = array.Max();
    int min = array.Min();

    int[] count = new int[max - min + 1];
    int z = 0;
    for (int i = 0; i < count.Length; i++) count[i] = 0;
    for (int i = 0; i < array.Length; i++) count[array[i] - min]++;

    for (int i = min; i <= max; i++) while (count[i - min]-- > 0)
        {
            array[z] = i;
            z++;
        }
}

int[] array1 = GenArray(123, 100, 999);
int[] array2 = array1;
Print1DArray(array1);

Console.WriteLine("Четных чисел в массиве: " + CountNumbers(array1));

BubbleSort(array1);
Print1DArray(array1);

CountSort(array2);
Print1DArray(array2);