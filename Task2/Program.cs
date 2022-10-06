//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

int max = Number1;
if (Number2>max) max = Number2;
if (Number3>max) max = Number3;

Console.WriteLine("Максимальное число: " + max);