//принимает на вход число и проверяет, является ли оно палиндромом

//принимает число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

//проверяет палиндром или нет
bool Test(int x)
{
    bool result = false;
    if ((x / 10000 == x % 10) && ((x / 1000) % 10) == ((x % 100) / 10)) result = true;
    return result;
}

int number = ReadData("Введите пятизначное число: ");
bool result = Test(number);
Console.WriteLine(result);