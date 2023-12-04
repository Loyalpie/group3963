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
int[] BubbleSort(int[] array)
{
    int[] sortArray = array;

    for (int j = 1; j < sortArray.Length; j++)
    {
        for (int i = 0; i < sortArray.Length - 1; i++)
        {
            if (sortArray[i] > sortArray[i + 1])
            {
                int temp = sortArray[i];
                sortArray[i] = sortArray[i + 1];
                sortArray[i + 1] = temp;
            }
        }

    }
    return sortArray;
}

int[] array = GenArray(100, 100, 999);
Print1DArray(array);
Console.WriteLine(CountNumbers(array));
int[] sortArray1 = BubbleSort(array);
Print1DArray(sortArray1);