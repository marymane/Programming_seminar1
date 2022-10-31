﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next (0,10);
        }
    }

}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
    Console.WriteLine();
    }
    
}

int[,] SortRowsDecreasing (int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array [i,k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                    
                }
            }
        }
    }
 return array;
}


int[,] matrix = new int [5,4];
FillArray (matrix);
Console.WriteLine("Исходный массив:");
PrintArray (matrix);
Console.WriteLine("А теперь массив, строки которого отсортированы по убыванию:");
PrintArray (SortRowsDecreasing (matrix));