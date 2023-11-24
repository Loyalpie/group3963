int number = new System.Random().Next(100, 1000);
Console.WriteLine("Number = " + number);
int answer = (number / 100 * 10 + number % 10);
Console.WriteLine(answer);