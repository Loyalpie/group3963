//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//МЕТОДЫ
//<ТИП> <ИМЯ МЕТОДА>(<ТИП> <НАЗВАНИЕ ПЕРЕМЕННОЙ>)

int ReadData(string msg)
{
    Console.WriteLine(msg); //что-то пишет в консоли (в переменной msg)
    return int.Parse(Console.ReadLine() ?? "0"); //возвращает какие-то данные введенные в консоль пользователем
}

void PrintQueterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка с данными координатами в 1 четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка с данными координатами во 2 четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка с данными координатами в 3 четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка с данными координатами в 4 четверти");
}

int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");

PrintQueterTest(coordX, coordY);