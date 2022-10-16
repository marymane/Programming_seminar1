//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Массив заполнен случайными числами из диапазона [0;100)


int[] array = new int[8];

void FillArray (int[] array)
{
    int length = array.Length; // метод написан для массива любой длины
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    
}

void PrintArray (int[] arr)
{
    int l = arr.Length; //метод написан для любой длины массива
    for(int i = 0; i<l; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}



FillArray (array);
PrintArray (array);