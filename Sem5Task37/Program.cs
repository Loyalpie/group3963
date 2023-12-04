// НАХОДИТ ПРОИЗВЕДЕНИЕ ПАР ЧИСЕЛ В МАССИВЕ (ПЕРВОЕ И ПОСЛЕДНЕЕ, ВТОРОЕ И ПРЕДПОСЛЕДНЕЕ ...) И ЗАПИСЫВАЕТ ИХ В НОВЫЙ МАССИВ

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


//находит произведение пар в массиве и записывает их значение в новый массив
int[] TransformationArray(int[] array)
{
    int number = 0; //переменная в которую записывается число в исходном массиве
    int newArrayLength = 0; // переменная - длина нового массива
    if ((array.Length % 2) == 0) newArrayLength = array.Length / 2; //если количество элементов в исходном массиве делится нацело на 2 то делим на 2
    else newArrayLength = array.Length / 2 + 1; // если нет то прибавляем 1 (так как число в середине массива не имееет пары и будет умножаться само на себя)

    int[] newArray = new int[newArrayLength]; //новый массив
    for (int i = 0; i < newArrayLength; i++) // до тех пор пока i меньше длины нового массива чтобы не перемножать те же числа [0] [9] и [9] [0]
    {
        number = array[i] * array[array.Length - 1 - i]; //находим произведение пар чисел исходного массива
        newArray[i] = number; //записываем значение выше в массив
    }
    return newArray;
}

int[] array = GenArray(100, -100, 100);
int[] newArray = TransformationArray(array);
Print1DArray(array);
Print1DArray(newArray);