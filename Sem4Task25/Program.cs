//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

double Calculator(int numA, int numB)
{
    double result = Math.Pow(numA, numB);
    return result;
}

//вывод данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int numberA = ReadData("Введите число A: "); //переменная А
int numberB = ReadData("Введите число B: "); //переменная B

double result = Calculator(numberA, numberB); //возведение А в степень В
PrintData($"A в степени B равно: {result.ToString()}"); //вывод результата

//===================================вторая часть программы с калькулятором============================================
PrintData("============Калькулятор============");

string ReadOperation(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();//int.Parse(Console.ReadLine());
}

//метод операций (считывает в качестве строки символ (+ - * / ^) и выполняет аналогичную операцию)
double Operations(string type, int numA, int numB)
{
    result = 0; //переменная-результат
    //сложение
    if (type == "+")
    {
        result = numA + numB;
    }
    //вычитание
    if (type == "-")
    {
        result = numA - numB;
    }
    //умножение
    if (type == "*")
    {
        result = numA * numB;
    }
    //деление
    if (type == "/")
    {
        result = numA / numB;
    }
    //возведение в степень
    if (type == "^")
    {
        result = Math.Pow(numA, numB);
    }
    return result;
}

numberA = ReadData("Введите число A: "); //переменная А
numberB = ReadData("Введите число B: "); //переменная B

string operation = ReadOperation("Введите операцию, которую необходимо сделать с числами А и В (+, -, /, *, ^): ");

result = Operations(operation, numberA, numberB); //расчет результата с помоьщью метода
PrintData($"Результат операции {numberA} {operation} {numberB} равен {result}"); //вывод результата