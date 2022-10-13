// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.0
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int GetNumber()
{
    Console.WriteLine("Введите пятизначное число!");
    int number = Convert.ToInt32(Console.ReadLine());  
    return number;
}


int GetReversed(int num)

	{
	int reverse = 0;
	int digit = 0;
	int temporary = num;
	while (temporary>0)
		{
		digit = temporary % 10;
		reverse = reverse*10+digit;
		temporary/=10;
		Console.WriteLine(temporary);
		}
	return reverse;
	}

void CheckIfPalindrom (int num, int rev)

	{
	if (num == rev)
		{
		Console.WriteLine("Введенное вами число - палиндром");
		}
	else
		{
		Console.WriteLine("Введенное вами число -   не палиндром");
		}	
	}

int N = GetNumber();
int reversed = GetReversed(N);
CheckIfPalindrom (N, reversed);
