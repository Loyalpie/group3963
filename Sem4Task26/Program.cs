//ПОЛУЧАЕТ ЧИСЛО И НАХОДИТ КОЛИЧЕСТВО ЦИФР В ЧИСЛЕ

//ввод данных
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

//вывод данных
void PrintResult(string result)
{
    Console.WriteLine(result);
}

//метод подсчета количества цифр в числе
int QuantityDigits(string number) //количество цифр - целое число
{
    return (int)number.Length; //т.к. число на входе - строка, то находим длину строки (= количесвто цифр в числе)
}


DateTime time = DateTime.Now; //записываем начало выполнения программы
string number = ReadData("Введите число: "); //вводим число в форме строки
int result = QuantityDigits(number); //результат целое число
Console.WriteLine(DateTime.Now - time); //выводим разницу между началом и окончанием работы программы (считаем сколько времени прога работала)
PrintResult(result + " цифр"); //выводим результат