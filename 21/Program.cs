// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Программа нахождения расстояния между точками в 3D пространстве.");
double GetCoordinateDistance (int userX1, int userY1, int userZ1, int userX2, int userY2, int userZ2)
{ 
    double distance = Math.Sqrt((Math.Pow((userX2-userX1),2)+Math.Pow((userY2-userY1),2)+Math.Pow((userZ2-userZ1),2))); 
    return distance; 
} 
Console.Write("Введите координату X1: "); 
int X1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату Y1: "); 
int Y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату Z1: "); 
int Z1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату X2: "); 
int X2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату Y2: "); 
int Y2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату Z2: "); 
int Z2 = Convert.ToInt32(Console.ReadLine()); 
double result = GetCoordinateDistance(X1,Y1,Z1,X2,Y2,Z2); 
Console.WriteLine($"Расстояние между точками X"+(X1,Y1,Z1)+"; Y"+(X2,Y2,Z2)+" = "+result);