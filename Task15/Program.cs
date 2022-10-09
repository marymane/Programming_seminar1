//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
void Weekend (int day)
{
    if (day > 7)
    {
        Console.Write ("В неделе всего 7 дней");
    }
    else if ((day==6) | (day==7))
    {
        Console.WriteLine ("Этот день - выходной");
    }
    else
    {
        Console.WriteLine ("Это не выходной день");
    }
}

Console.WriteLine ("Введите номер дня недели");
int weekday = Convert.ToInt32(Console.ReadLine()); 
Weekend(weekday);