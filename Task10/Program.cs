//Напишите программу, 
//которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

Random createNumber =new Random();
int number = createNumber.Next(99, 1000);

int a = number / 100;
int b = number % 10;

Console.WriteLine($" Random {number}. Delete the second digit. {a}{b}"); 
