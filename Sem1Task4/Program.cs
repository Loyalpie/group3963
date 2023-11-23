Console.WriteLine("Введите первое число: ");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? numLine2 = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string? numLine3 = Console.ReadLine();

int num1 = int.Parse(numLine1);
int num2 = int.Parse(numLine2);
int num3 = int.Parse(numLine3);

if (num1 > num2) {
    if (num1 > num3) 
    {
        Console.Write(num1);
    }
    else {
        Console.Write(num3);
    }
}
else {
    if(num2 > num3) 
    {
        Console.Write(num2);
    }
    else {
    Console.Write(num3);
    }
}