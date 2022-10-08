//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

int CreateNumber()
{
return  new Random().Next(10,1000);
}

int ThirdNumber (int Number)
{
return (Number % 10);
}
 
 int num = CreateNumber();
 Console.WriteLine("Имеем число " + num);
 if (num < 100)
    {
    Console.WriteLine("Число двузначное, третьей цифры нет");
    }
else 
    {
    Console.WriteLine("Третья цифра - " + ThirdNumber (num));  
    }
 
