//Задача №1. Напишите программу, 
//которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Enter the first number ");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);

Console.WriteLine("Enter the second number ");
string example1 = Console.ReadLine();
int b = Convert.ToInt32(example1);

if(b * b == a)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}