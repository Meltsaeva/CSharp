//Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Enter The First Number ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter The Second Number ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;

if (a < max) min = a;
if (b < max) min = b;

Console.WriteLine("max= ");
Console.WriteLine(max);
Console.WriteLine("min= ");
Console.WriteLine(min);
