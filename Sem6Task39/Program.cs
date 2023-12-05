// ПЕРЕВОРАЧИВАЕТ МАССИВ ЗАДОМ НАПЕРЕД

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

//метод переворачивает массив
void ReversArray(int[] array)
{
    int count = 0;
    if (array.Length % 2 == 0) count = array.Length / 2;
    else count = array.Length / 2 + 1;

    for (int i = 0; i < count; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

//создает новый массив из старого
int[] ReversArrayNewArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[array.Length - 1 - i];
    }
    return newArray;
}

int[] array = GenArray(11, -10, 10);
int[] newArray = ReversArrayNewArray(array);
Print1DArray(array);

ReversArray(array);
Print1DArray(array);

Print1DArray(newArray);