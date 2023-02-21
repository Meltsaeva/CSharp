//Напишите программу, 
//которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.


Console.WriteLine("Input X ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || y == 0)
{
    Console.WriteLine("Input X != 0 and Y != 0");
}
else if(x > 0 && y > 0)
{
    Console.WriteLine("I");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("II");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("III");
}
else
{
    Console.WriteLine("IV");
}