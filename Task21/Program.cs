//Напишите программу, 
//которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number <10000)
{
    Console.WriteLine("Incorrect");
}

else 
{
    int a = number / 10000;
    int b = number / 1000 % 10;
    int c = number / 100 % 10;
    int d = number / 10 % 10;
    int e = number % 10;
    if (a == e && b == d)
    Console.WriteLine("It's actually a palindrome, guys");
    else 
    Console.WriteLine("It isn't a palindrome, guys");
}