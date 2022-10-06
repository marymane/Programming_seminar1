//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if ((Number % 2) != 0)
{
Console.WriteLine("Число нечетное");
}
else
{
Console.WriteLine("Число четное");
}