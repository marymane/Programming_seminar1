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

Console.WriteLine("Выведем все натуральные числа в промежутке от N до 1");
Console.WriteLine("Введите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0) 
    {Console.Write ("Число N - меньше нуля, натуральных чисел в промежутке от N до 1 нет");}
else    
    {PrintAllNatural (N);}