//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int CreateNumber()
{
return  new Random().Next(100,1000);
}

int SecondDigit (int Number)
{

return ((Number % 100)/10);
}
 int num = CreateNumber();
 Console.WriteLine("Трехзначное число: " + num);
 Console.WriteLine("Второй разряд числа равен " + SecondDigit (num));