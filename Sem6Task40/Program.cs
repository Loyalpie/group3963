// НА ВХОД БЕРЕТ 3 ЧИСЛА И ПРОВЕРЯЕТ СУЩЕСТВУЕТ ЛИ ТРЕУГОЛЬНИК С ТАКИМИ СТОРОНАМИ

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//проверяет существует ли треугольник
bool CheckTriangle(int a, int b, int c)
{
    if ((a + b) >= c) return true;
    else return false;
}

int a = ReadData("Введите A: ");
int b = ReadData("Введите B: ");
int c = ReadData("Введите C: ");

Console.WriteLine(CheckTriangle(a,b,c));