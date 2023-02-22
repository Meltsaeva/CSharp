//Напишите программу, 
//которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек 
//в этой четверти (x и y).

Console.WriteLine("Input from 1 to 4");
int a = Convert.ToInt32(Console.ReadLine());

//if(a == 1)
//{
//    Console.WriteLine("x = +, y = +");
//}
//else if(a == 2)
//{
//   Console.WriteLine("x = -, y = +");
//}
//else if(a == 3)
//{
//    Console.WriteLine("x = -, y = -");
//}
//else if(a == 4)
//{
//    Console.WriteLine("x = +, y = -");
//}
//else
//    Console.WriteLine("Incorrect");

    switch (a)
    {
        case 1:
        Console.WriteLine(" = +, y = +");
        break;
        case 2:
        Console.WriteLine("x = -, y = +");
        break;
        case 3:
        Console.WriteLine("x = -, y = -");
        break;
        case 4:
        Console.WriteLine("x = +, y = -");
        break;
        
        default:
        Console.WriteLine("Incorrect");
        break;
    }
    