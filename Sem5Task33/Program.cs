//ПРОВЕРЯЕТ ПРИСУТСТВУЕТ ЛИ ЗАДАГГЛЕ ЧИСЛО В МАССИВЕ

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

//метод проверки числа в массиве
int SearchNumber(int number, int[] array)
{
    int result = -1;  //если числа нет в массиве выводит -1
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])                 //Console.WriteLine($"Число {number} есть в массиве. Идекс - {i + 1}");
        {                                        //else Console.WriteLine($"Числа {number} нет в массиве");
            result = i; //если число есть выводит его индекс
            break;
        }
    }
    return result;
}

int[] array = GenArray(10, -10, 10);
Print1DArray(array);

int number = ReadData("Введите число: ");
int result = SearchNumber(number, array);

if (result >= 0)
{
    Console.WriteLine($"Число {number} есть в массиве. Идекс - [{result}]");
}
else Console.WriteLine("Такого числа в массиве нет");