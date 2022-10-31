// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrixFilling (int[,] array)
{
    int index = 0;
    int columns = 4;
    int currentRow = 0;
    int currentColumn = 0;
    int changeIndexRow = 0;
    int changeIndexColumn = 1;
    int steps = 4;
    int temp;
    int turn = 0;
    while (index < array.Length)
    {
        array[currentRow,currentColumn] = index + 1;
        index++;
        steps--;
        if (steps == 0)
        {
            steps = columns - 1 - turn/2;
            temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            turn++;
        }

        currentRow += changeIndexRow;
        currentColumn += changeIndexColumn;
    }
    return array;
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

int[,] matrix = new int[4,4];
PrintArray(SpiralMatrixFilling(matrix));