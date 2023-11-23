Console.WriteLine("Enter num: ");
string? numString = Console.ReadLine();

int num = int.Parse(numString);
string [] dayWeek = new string [7];
dayWeek[0] = "понедельник";
dayWeek[1] = "вторник";
dayWeek[2] = "среда";
dayWeek[3] = "четверг";
dayWeek[4] = "пятница";
dayWeek[5] = "суббота";
dayWeek[6] = "воскресенье";

Console.WriteLine("День недели - " + dayWeek[num - 1]);