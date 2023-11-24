string? numberLine = Console.ReadLine();
int number = int.Parse(numberLine);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}