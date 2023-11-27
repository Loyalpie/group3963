string? numberLine = Console.ReadLine();

int number = int.Parse(numberLine);
int secondDigit = (((number % 100) - (number % 10)) / 10);

Console.WriteLine(secondDigit);