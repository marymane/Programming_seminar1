//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int remain = 0;
Console.WriteLine("Все четные числа до " + N + ":");
while (i<=N)
{
    remain = i % 2;
         if (remain == 0)
        {	  
	     Console.WriteLine(i);
		 i++;
	    }
        else
		{
		i++;
		}	
}