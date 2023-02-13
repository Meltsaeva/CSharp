//Напишите программу, 
//которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Enter a number ");
int a = Convert.ToInt32(Console.ReadLine());

if(a / 100 != 0 && a / 100 < 9 && a / 100 > 1)
{
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("This number isn't correct");
}