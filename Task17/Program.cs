//Напишите программу, 
//которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.


//Console.WriteLine("Input X ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input Y ");
//int y = Convert.ToInt32(Console.ReadLine());

//if(x == 0 || y == 0)
//{
 //   Console.WriteLine("Input X != 0 and Y != 0");
//}
//else if(x > 0 && y > 0)
//{
//    Console.WriteLine("I");
//}
//else if(x < 0 && y > 0)
//{
//    Console.WriteLine("II");
//}
//else if(x < 0 && y < 0)
//{
//    Console.WriteLine("III");
//}
//else
//{
//    Console.WriteLine("IV");
//}

int[] points = new int[2];
for (int i = 0; i < points.Length; i++)
{
    while (true)
    {
        points[i] = Convert.ToInt32(Console.ReadLine());
    if (points[i] != 0)
        break;
    else
        Console.WriteLine("Input X and Y != 0");
    }
}


if (points[0] > 0 && points[1] > 0)
    Console.WriteLine("I");
else if (points[0] < 0 && points[1] > 0)
    System.Console.WriteLine("II");
else if (points[0] < 0 && points[1] < 0)
    System.Console.WriteLine("III");
else System.Console.WriteLine("IV");


