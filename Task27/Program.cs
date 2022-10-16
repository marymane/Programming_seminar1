// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber()
{
    Console.WriteLine("Введите многозначное число");
    int number = Convert.ToInt32(Console.ReadLine());  
    return number;
}

int GetSumOfDigits (int num)

{
	int sum = 0;
	while (num>0)
	{
	sum+=num%10;
	num/=10;
	}
return sum;
}

int N = GetNumber();

Console.WriteLine($"Сумма всех разрядов числа равна {GetSumOfDigits (N)}");
