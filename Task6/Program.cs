//Напишите программу,
//которая на вход принимает число и выдаёт, 
//является ли число чётным 
//(делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter a number ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}