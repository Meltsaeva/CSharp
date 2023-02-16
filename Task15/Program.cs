//Напишите программу,
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("didn't find");
}
else {

while (a > 999)
{
    a /= 10;
}
a %= 10;
Console.WriteLine(a);
}
   




