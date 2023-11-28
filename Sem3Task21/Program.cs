//принимает координаты XYZ двух точек и находит расстояние между ними

//метод принимает данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

//метод рассчитывает расстояние между точками
double Calculator(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)); //формула рассчета расстояния между точками
    return result;
}

//координаты точки A
int Ax = ReadData("Введите X-координату точки A");
int Ay = ReadData("Введите Y-координату точки A");
int Az = ReadData("Введите Z-координату точки A");
//координаты точки B
int Bx = ReadData("Введите X-координату точки B");
int By = ReadData("Введите Y-координату точки B");
int Bz = ReadData("Введите Z-координату точки B");

Console.WriteLine("Расстояние между точками A и B равно: " + Calculator(Ax, Ay, Az, Bx, By, Bz));