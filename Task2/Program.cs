//Задача №3. Напишите программу, 
//которая будет выдавать название дня недели 
//по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Enter a number ");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);

if(a == 1)
{
    Console.WriteLine("Monday");
}
if(a == 2)
{
    Console.WriteLine("Tuesday");
}
if(a == 3)
{
    Console.WriteLine("Wednesday");
}
if(a == 4)
{
    Console.WriteLine("Thursday");
}
if(a == 5)
{
    Console.WriteLine("Friday");
}
if(a == 6)
{
    Console.WriteLine("Saturday");
}
if(a == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Enter from 1 to 7");
}