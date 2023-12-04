//ЗАДАТЬ МАССИВ ИЗ 12 ЭЛЕМЕНТОВ ОТ -9 ДО 9. НАЙТИ СУММУ ОТРИЦАТЕЛЬНЫХ И ПОЛОЖИТЕЛЬНЫХ ЭЛЕМЕНТОВ МАССИВА

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

//вывод вывода в консоль
void PrintData(string result, int value)
{
    Console.WriteLine(result + value);
}

//метод нахождения суммы положительных и отрицательных чисел массива
(int positive, int negative) NegativeAndPositiveSum(int[] array)
{
    int positiveSum = 0; // сумма позитивных чисел
    int negativeSum = 0; // сумма негативных чисел

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positiveSum += array[i];
        }
        else
        {
            negativeSum += array[i];
        }
    }

    return (positiveSum, negativeSum);
}

int[] testArray = GenArray(12, -9, 9); //создание массива
Print1DArray(testArray);

(int positive, int negative) results = NegativeAndPositiveSum(testArray); // создаем переменную results у которой 2 значения
PrintData("Сумма положительных значений в массиве: ", results.positive);
PrintData("Сумма отрицательных значений в массиве: ", results.negative);