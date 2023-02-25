//Напишите программу, 
//которая принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int number = GetNumber();
Console.WriteLine($"Sum is {Sum(number)}");

int GetNumber()
{
    Console.WriteLine("Input a number");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}   
int Sum(int a) 
{
    int result = 0;
    for (int i = 0; i <= a; i++)
    {
        result += i;
    }
    return result;
}