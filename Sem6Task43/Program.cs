// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод нахождения координат точек пересечения прямых
string CoordPoints(double b1, double k1, double b2, double k2)
{
    double xCoord = (b2 - b1) / (k1 - k2);
    double yCoord = k1 * xCoord + b1;
    string answer = "(" + xCoord + " " + yCoord + ")";
    return answer;
}

double b1 = ReadData("Введите b1: ");
double k1 = ReadData("Введите k1: ");
double b2 = ReadData("Введите b2: ");
double k2 = ReadData("Введите k2: ");

Console.WriteLine(CoordPoints(b1, k1, b2, k2));