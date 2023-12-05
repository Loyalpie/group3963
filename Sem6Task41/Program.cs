// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод учета введенных чисел (они помещаются в массив)
int[] EnterNumbers(int quantity)
{

    int[] array = new int[quantity];
    for (int i = 0; i < array.Length; i++)
    {
        int number = ReadData("Введите число: ");
        array[i] = number;
    }
    return array;
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

//метод подсчета чисел больше нуля
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > 0) count++;
    return count;
}


int quantity = ReadData("Количество чисел: ");
int[] array = EnterNumbers(quantity);
Print1DArray(array);
Console.WriteLine($"Чисел больше нуля: {CountEvenNumbers(array)}");