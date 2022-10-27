// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
    
}

void FindMatrixElement (int[,] matrix)
{
    Console.WriteLine("Введите значения индексов искомого элемента");
    Console.Write("i = ");
    int iTemp = Convert.ToInt32(Console.ReadLine());
    Console.Write("j = ");
    int jTemp = Convert.ToInt32(Console.ReadLine());
    if (iTemp > 5 || jTemp > 6 || iTemp < 0 || jTemp < 0)
        Console.WriteLine("Такого элемента в массиве не существует");
    else 
        Console.Write($"Элемент с индексами {iTemp} и {jTemp}  равен {matrix[iTemp,jTemp]}");

}

int[,] matrix = new int [5,6];
FillArray (matrix);
PrintArray (matrix);
FindMatrixElement(matrix);