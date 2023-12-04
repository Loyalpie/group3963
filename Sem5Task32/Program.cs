//ЗАМЕНИТЬ В МАССИВЕ ПОЛОЖИТЕЛЬНЫЕ ЧИСЛА НА ОТРИЦАТЕЛЬНЫЕ И НАОБОРОТ

//метод генерации массива
int[] GenArray(int number, int min, int max)
{
    if (min > max) //если минимальное больше максимального - меняем местами
    {
        int buf = min;
        min = max;
        max = buf;
    }

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


// метод замены в массиве положительных чисел на отрицательные и наоборот
void ReplacingNumbers(int[] array)
{
  //  int[] arrayNew = new int[array.Length]; // создание нового массива который будем заполнять числами *(-1)
    for (int i = 0; i < array.Length; i++) array[i] = -array[i];
  //  return arrayNew;
}

int[] arrayOrigin = GenArray(10, -10, 10);
//int[] arrayReplaced = ReplacingNumbers(arrayOrigin);

Print1DArray(arrayOrigin); // оригинальный массив
ReplacingNumbers(arrayOrigin); // меняем числа
Print1DArray(arrayOrigin); // новый массив (вернее старый с противоположными числами)