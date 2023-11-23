string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int startNumber = inputNumber * (-1);
    string outLine = string.Empty;

    while(startNumber < inputNumber)
    {
        outLine += startNumber + ", ";
        startNumber ++;
    }
    outLine += inputNumber;

    Console.WriteLine(outLine);
}