//Напишите программу, 
//которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("Input a number ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number < 100000 && number <10000)
//{
//    Console.WriteLine("Incorrect");
//}

//else 
//{
//    int a = number / 10000;
//    int b = number / 1000 % 10;
//    int c = number / 100 % 10;
//    int d = number / 10 % 10;
//    int e = number % 10;
//    if (a == e && b == d)
//    Console.WriteLine("It's actually a palindrome, guys");
//    else 
//    Console.WriteLine("It isn't a palindrome, guys");
//}

//char is a keyword that is used to declare a variable
// which store a character value from the range of +U0000 to U+FFFF

//bool - which can be either true or false 
// The bool type is the result type of comparison and equality operators.

Console.WriteLine("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100000 || number < 9999)
  Console.WriteLine("Incorrect");
else 
{
    char[] palindrome = number.ToString().ToCharArray();
    bool isPalindrome = true;
    for (int i=0; i < palindrome.Length / 2; i++)
    {
        if (palindrome[i] != palindrome[palindrome.Length - i -1])
            isPalindrome = false;
    }
    Console.WriteLine("Current number is palindrome - {0}", isPalindrome);
}
