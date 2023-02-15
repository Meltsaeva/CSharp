//Напишите программу, 
//которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Random createNumber =new Random();
int number = createNumber.Next(10, 100);

//[0, 5] - 0 и 5 включены в диапазон
//(0, 5) - 0 и 5 не включены в диапазон

int a = number / 10;
int b = number % 10;

if(a > b)
    Console.WriteLine($"The first number is more than the second {a} > {b}");
else if(a < b)
    Console.WriteLine($"The second number is more than the first {a} < {b}");
else
    Console.WriteLine($"The numbers are equal {a} = {b}");

//Console.WriteLine("text example" + a);
//Console.WriteLine("text {0} example {1}", a, b);
//Console.WriteLine($"text {a + b} example {b}");