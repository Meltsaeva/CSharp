
// Напишите программу, 
// которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// #region 


// int number = Prompt("Input a number");
// Count(number);

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// void Count(int userNumber)
// {
//     char[] number = userNumber.ToString().ToCharArray();
//     Console.WriteLine($"{number.Length}");
// }

// #endregion

// // Напишите программу, 
// // которая принимает на вход число N и 
// // выдаёт произведение чисел от 1 до N.
// // 4 -> 24
// // 5 -> 120

// #region 

// int number1 = GetNumber();
// Console.WriteLine($"Product is {Pro(number1)}");

// int GetNumber()
// {
//     Console.WriteLine("Input a number");
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     return number1;
// }   
// int Pro(int a) 
// {
//     int result = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// #endregion


int GetNumber()
{
    Console.WriteLine("Input a number");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Numbers()
{
    int a = GetNumber();
    int count = 0;
    while (a > 0)
    {
        a = a / 10;
        count ++;
    }
    return count;
}
 
int Result()
{
    int b = GetNumber();
    int x = 1;
    for (int i = 1; i <= b; i++)
    {
        x = x*i;
    }
    return x;
}

Console.WriteLine(Result()); // Result or Numbers