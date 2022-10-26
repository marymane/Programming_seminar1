//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

 

// //int m = Convert.ToInt32(Console.ReadLine());
// //int m = GetDimention ();
// //int n = GetDimention ();
// double[,] array = new double [5,8];
// FillArray(array);
// PrintArray(array);

void FillArray (double[,] array)
{
Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * 10 - 20; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        }
        
    }
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
  
  
Console.Write ("Введите размерность массива m ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите размерность массива n ");
int n = Convert.ToInt32 (Console.ReadLine());

double[,] matrix = new double[m,n];
FillArray (matrix);
PrintArray (matrix);