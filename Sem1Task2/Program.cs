string? numLine1 = Console.ReadLine();
string? numLine2 = Console.ReadLine();

int num1 = int.Parse(numLine1);
int num2 = int.Parse(numLine2);

if (num1 > num2) {
    Console.WriteLine("Первое число " + num1 + " больше второго " + num2);
}
else{
    Console.WriteLine("Второе число "+ num2 + " больше первого "+ num1);
}