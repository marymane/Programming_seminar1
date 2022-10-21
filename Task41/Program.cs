// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray (int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
}

void PrintArray (int[] arr)
{
    
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}


int PositiveElements(int[] arr)
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            counter++;
        }
    }

    return counter;
}



Console.WriteLine("Сколько чисел будем вводить?");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
FillArray(array);
PrintArray(array);
Console.Write($" ввели {PositiveElements(array)} положительных");