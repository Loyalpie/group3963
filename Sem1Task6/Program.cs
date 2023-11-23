Console.WriteLine("Введите число: ");
string? numLine = Console.ReadLine();

int num = int.Parse(numLine);

if (num % 2 == 0) {
    Console.Write("Четное");
}
else {
    Console.Write("Нечетное");
}
