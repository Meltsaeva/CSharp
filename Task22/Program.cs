//Напишите программу, 
//которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

double[] a = new double[3];
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine($"Input the first coordinates");
    a[i] =Convert.ToDouble(Console.ReadLine());
    
}


double[] b = new double[3];
for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine($"Input the second coordinates");
    b[i] =Convert.ToDouble(Console.ReadLine());
    
}

double x = Math.Pow(b[0] - a[0], 2);
double y = Math.Pow(b[1] - a[1], 2);
double z = Math.Pow(b[2] - a[2], 2);
double distance = Math.Sqrt(x + y + z);
Console.WriteLine($"The interval between the two points is {distance}");
