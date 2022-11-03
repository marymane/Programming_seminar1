// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintAllNatural (int N)
{
    if (N == 1) 
    Console.Write (N);

    else
    {
        Console.Write (N + ",");
        N--;
        PrintAllNatural (N);
    }
}


double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbers(double lastNumber)
{
    int counter = 1;
    while(counter <= lastNumber)
    {
        if (counter + 1 <= lastNumber)
            Console.Write(counter + ", ");
        else
            Console.Write(counter);
        counter++;
    }
}

string WriteNumbersRecursion(int startNumber, double lastNumber)
{
    if (startNumber <= lastNumber)
        return startNumber + ", " + WriteNumbersRecursion(startNumber+1, lastNumber);
    
    return string.Empty;
}

void WriteNumbersRecursionVoid(int startNumber, double lastNumber)
{
    if (startNumber <= lastNumber)
    {
        Console.Write(startNumber + ", ");
        WriteNumbersRecursionVoid(startNumber+1, lastNumber);
    }     
}

double number = GetNumberFromConsole();
WriteNumbers(number);
Console.WriteLine();
Console.Write(WriteNumbersRecursion(1, number));
Console.WriteLine();
WriteNumbersRecursionVoid(1, number);

int N = Convert.ToInt32(Console.ReadLine());
PrintAllNatural (N);