Console.WriteLine("Введите число: ");
string? numLine = Console.ReadLine();

int num = int.Parse(numLine);

for (int i = 2; i < num; i += 2) {
    Console.Write(i + " ");
}