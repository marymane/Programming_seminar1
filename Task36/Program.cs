// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

void FillArray (int[] array)
{
    int length = array.Length; 
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    
}

void PrintArray (int[] arr)
{
    int l = arr.Length; 
    for(int i = 0; i<l; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}

int SumOfOddIndex (int[] arr)
{
    int l = arr.Length;
    int sum = 0;
    for(int i=1;i<l;i+=2)
    {
       sum+=arr[i];
    }
    return sum;
}

FillArray (array);
PrintArray (array);
Console.WriteLine ("-> " + SumOfOddIndex(array) + " - сумма элементов с нечетными индексами");