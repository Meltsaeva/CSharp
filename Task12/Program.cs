﻿//Напишите программу, 
//которая будет принимать на вход два числа и выводить, 
//является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, 
//то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Input the first number ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number ");
int b = Convert.ToInt32(Console.ReadLine());

if(a % b == 0)
    Console.WriteLine("кратно");
else
{
    int c = a % b;
    Console.WriteLine($"не кратно, остаток {c}");
}