//Напишите программу, 
//которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8

Console.WriteLine("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100 || a > 999)
{
    Console.WriteLine("Incorrect");
}

else 
{
    int b = a /10 % 10;
    Console.WriteLine(b);
}