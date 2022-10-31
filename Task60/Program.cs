// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] FillUniqueNumbers(int min, int max, int arraySize)
{
    Random random = new Random();
    int[]array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.Next(min, max); 
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
                {
                    i--;
                }
        } 
        Console.Write($"{array[i]} ");    
    }
    return array;
}

void FillArray3D (int[,,] array, int[] temp)
{
    int step = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = temp[i+j+k+step];
            }
            step+=array.GetLength(1)-1;
            
        }
        step+=array.GetLength(2)-1;
    }
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите 1-ю размерность трехмерного массива -> ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ю размерность трехмерного массива -> ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ю размерность трехмерного массива -> ");
int z = Convert.ToInt32(Console.ReadLine());
if (x*y*z > 90)
{
    Console.Write("Ваш массив невозможно заполнить неповторяющимися двузначными числами");
}
else
{
    int[,,] matrix3D = new int[x,y,z];
    FillArray3D(matrix3D,FillUniqueNumbers(10,100,matrix3D.Length));
    Console.WriteLine($"Заполнили ваш массив размерностью {x}x{y}x{z} двузначными неповторяющимися числами:");
    PrintArray3D(matrix3D);
}