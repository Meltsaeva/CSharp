// Напишите программу, 
//которая принимает на вход координаты двух точек
// и находит расстояние между ними 
//в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Input x1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input x2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2");
double y2 = Convert.ToInt32(Console.ReadLine());

double x3 = Math.Pow(x2 - x1, 2);
double y3 = Math.Pow(y2 - y1, 2);
double distance = Math.Sqrt(x3 + y3);
Console.WriteLine($"The interval between the two points is {distance}");
