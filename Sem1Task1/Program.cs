Console.WriteLine("Введите первое число: ");
string? inputNum1 = Console.ReadLine(); //считываем данные с консоли

Console.WriteLine("Введите второе число: ");
string? inputNum2 = Console.ReadLine(); //считываем данные с консоли


//проверяем на пустое число
if(inputNum1 != null && inputNum2 != null)
{
    //парсим
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);

    if (num2 * num2 == num1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
    
 
}