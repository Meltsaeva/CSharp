//Напишите программу, 
//которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
// \t - used to place a tab space between words.

Console.WriteLine("Input N");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    System.Console.Write($"{i*i*i}\t");
}