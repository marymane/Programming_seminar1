// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 

// 2, 4 -> 16


int GetNumber()
{
    Console.WriteLine("Введите натуральное число");
    int number = Convert.ToInt32(Console.ReadLine());  
    return number;
}

int RaiseDegree (int n1, int n2)

	{
	int result = 1;
	for (int i=1; i<=n2; i++)
		{
		result*=n1;
		}
	return result;	
	}

int a = GetNumber();
int b = GetNumber();
//int degree = RaiseDegree (a,b);
Console.WriteLine($"{a} в степени {b} = {RaiseDegree (a,b)}");