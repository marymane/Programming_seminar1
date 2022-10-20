// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

 


int[] array = new int[10];

void FillArray (int[] array)
{
    int length = array.Length; 
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(100,1000);
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

int NumberOfEven (int[] arr)
{
    int l = arr.Length;
    int count = 0;
    for(int i=0;i<l;i++)
    {
        if (arr[i]%2==0)
        {
            count+=1;
        }
    }
    return count;
}

FillArray (array);
PrintArray (array);
Console.WriteLine ("->" + NumberOfEven(array) + " четных элемента");