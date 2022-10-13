// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetCoordinate(string name)
{
    
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());  
    
}

double Distance3D (double x1,double x2,double y1,double y2,double z1,double z2)
	{
	return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
	}
	
	double x1 = GetCoordinate ("x1");
    double y1 = GetCoordinate ("y1");
    double z1 = GetCoordinate ("z1");
    double x2 = GetCoordinate ("x2");
    double y2 = GetCoordinate ("y2");
    double z2 = GetCoordinate ("z2");
    Console.WriteLine("Расстояние между точками в 3D пространстве равно  " 
                        +  Distance3D (x1,x2,y1,y2,z1,z2));