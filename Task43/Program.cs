// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void PrintArray (double[] arr)
{
    
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}
void Intersecrion (double K1, double B1, double K2, double B2)
{
    double[] intersection = new double[2];
    intersection[0] = Math.Round ((B2 - B1)/(K1 - K2),1);
    intersection[1] = Math.Round (K1 * intersection[0] + B1, 1);
    Console.Write("Координаты точки пересечения прямых: ");
    PrintArray(intersection);
}



Console.Write("Введите угловой коэффициент прямой k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());  
Console.Write("Введите вертикальное смещение прямой b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите угловой коэффициент прямой k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());  
Console.Write("Введите вертикальное смещение прямой b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine ("Прямые параллельны, точки пересечения нет");
}
else 
{
    Intersecrion (k1, b1, k2, b2);
}