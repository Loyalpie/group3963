// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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


//метод подсчета суммы чисел в массиве, стоящих на нечетных позициях
int SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) if (i % 2 != 0) sum += array[i];
    return sum;
}

int[] array = GenArray(10, -10, 10);
Print1DArray(array);
Console.WriteLine(SumOddNumbers(array));