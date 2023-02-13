//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

Console.WriteLine("Enter a number ");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);

Console.WriteLine("Output: ");
int result = a * a;
Console.WriteLine(result);

