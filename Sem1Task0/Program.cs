
Console.WriteLine("Введите число: ");

string? inputNum = Console.ReadLine(); //считываем данные с консоли


//проверяем на пустое число
if(inputNum != null)
{
    //парсим введенное число
    int number = int.Parse(inputNum);
    
    //находим кадрат от числа
    int outNum = number * number;

    //выводим данные в консоль
    Console.WriteLine("Квадрат числа равен "+ outNum);
}