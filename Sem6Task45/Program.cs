// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

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

//создает новый массив с помощью поэлементного копирования
int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    //for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
    array.CopyTo(newArray,0); //копирование старого массива в новый с 0 элемента
    return newArray;
}

int[] array = GenArray(10, -10, 10);
Print1DArray(array);

int[] newArray = CopyArray(array);
Print1DArray(newArray);