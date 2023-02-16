//Напишите программу, 
//которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());

if (0 < a && a < 6)
{
    Console.WriteLine("No");
}
else if (5 < a && a < 8)
    {
        Console.WriteLine("Yes");
    }
else 
{
    Console.WriteLine("Input the correct number");
}