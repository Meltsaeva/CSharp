//Напишите программу, 
//которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа
// в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Enter a number ");
int a = Convert.ToInt32(Console.ReadLine());
int i = -1 * Math.Abs(a);

while(i <= Math.Abs(a))
{
    Console.WriteLine(i);
    i++;
} 