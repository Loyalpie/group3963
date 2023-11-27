//программа принимает координаты двух точек и вывод расстояние между этими точками

//метод ввода данных (координат)
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");  //??"0" нужно чтобы в консоли желтая ошибка не выскакивала
}

//метод расчета расстояния между двумя точками
void DistanceCalculator(double x1, double y1, double x2, double y2)
{
    var result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //формула расчета расстояния sqrt((x2 - x1)^2 + (y2 - y1)^2)
    Console.WriteLine(result); // выводит результат
}

//ввод данных
int coordAx = ReadData("Введите координаты X точки A: ");
int coordAy = ReadData("Введите координаты Y точки A: ");
int coordBx = ReadData("Введите координаты X точки B: ");
int coordBy = ReadData("Введите координаты Y точки B: ");

//вывод расстояния между точками
DistanceCalculator(coordAx, coordAy, coordBx, coordBy);