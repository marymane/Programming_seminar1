// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[4];

void FillArray (double[] array)
{
    int length = array.Length; 
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    
}

void PrintArray (double[] arr)
{
    int l = arr.Length; 
    for(int i = 0; i<l; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}

double DiffOfMinMax (double[] arr)
{
    int l = arr.Length;
    double min = arr[0];
    double max = arr[0];
    for(int i=0;i<l;i++)
    {
       if (min>arr[i])
       {
        min = arr[i];
       }

        if (max<arr[i])
       {
        max = arr[i];
       }
    }
    return (max - min);
}

FillArray (array);
PrintArray (array);
Console.WriteLine ("-> " + DiffOfMinMax(array) + " - Разность между макс и мин элементами");