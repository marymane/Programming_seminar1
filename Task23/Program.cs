﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
 
int GetNumber()
{
    
    Console.WriteLine("Введите число!");
    int number = Convert.ToInt32(Console.ReadLine());  
    return number;
}

void TableOfThirdDegree (int number)
	{
	int i=1;
	while (i<=number)
		{
		Console.WriteLine($"{i}*{i}*{i} = {Math.Pow(i,3)}");
        i++;
		}
	}
	
int N = GetNumber();
TableOfThirdDegree(N);