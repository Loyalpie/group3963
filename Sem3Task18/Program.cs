//программа по заданному номеру четверти определяет диапазон координат точек

//метод приема числа из консоли
int ReadData(string msg)
{
    Console.Write(msg); //в переменную msg записывается сообщение
    return int.Parse(Console.ReadLine()); //здесь принимаются данные введенные в консоли пользователем, ВОЗВРАЩАЕТ введенные данные
}

//метод определения координат
void Coordinats(int n)
{
    if (n == 1) //первая четверть координатной плоскости
    {
        Console.WriteLine("Координаты 1 четверти: "); 
        Console.WriteLine("X от 0 до +бесконечности");
        Console.WriteLine("Y от 0 до +бесконечности");
    }
    if (n == 2) //2-я
    {
        Console.WriteLine("Координаты 2 четверти: "); 
        Console.WriteLine("X от 0 до +бесконечности");
        Console.WriteLine("Y от 0 до -бесконечности");
    }
    if (n == 3) //3-я
    {
        Console.WriteLine("Координаты 3 четверти: "); 
        Console.WriteLine("X от 0 до -бесконечности");
        Console.WriteLine("Y от 0 до +бесконечности");
    }
    if (n == 4) //4-я
    {
        Console.WriteLine("Координаты 4 четверти: "); 
        Console.WriteLine("X от 0 до -бесконечности");
        Console.WriteLine("Y от 0 до +бесконечности");
    }
}

int coordPlaneNumber = ReadData("Введите номер координатной плоскости: "); //в переменную coordPlaneNumber будет записываться число введенное в консоли
Coordinats(coordPlaneNumber); //выводит координаты точек