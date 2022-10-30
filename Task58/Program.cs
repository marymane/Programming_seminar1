// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] MatrixMultiplication (int[,] arr1, int[,] arr2)
{
    
    if (arr1.GetLength(1) != arr2.GetLength(0)) 
        Console.WriteLine("Матрицы нельзя перемножить");
    int[,] multiple = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    multiple[i,j] += arr1[i,k] * arr2[k,j];
                }
            }
        }
        return multiple;
}

int[,] array1 = new int [2,2];
int[,] array2 = new int [2,2];
FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine("Результирующая матрица, полученная умножением данных матриц:");
PrintArray(MatrixMultiplication(array1, array2));