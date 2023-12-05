// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//метод генерации массива
double[] GenArray(int number, int min, int max)
{
    double[] array = new double[number]; //создание массива с number-количеством элементов

    //заполнение массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1) + (new Random().NextDouble()); //заполнение случайными числами от min до max
        array[i] = Math.Round(array[i], 2); //округление до 2 чисел после запятой
    }
    return array; //возвращение массива
}

//метод "рисования" одномерного массива
void Print1DArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

//сортировка методом пузырька (самый большой элемент поднимается наверх)
void BubbleSort(double[] array)
{
    for (int j = 1; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                double temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

double[] array = GenArray(123, -10, 10);
Print1DArray(array);

BubbleSort(array);
Print1DArray(array);

Console.WriteLine("Разница между минимальным и максимальным значением равна " + (array[array.Length - 1] - array[0]));