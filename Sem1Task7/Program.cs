// Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine()??"0");
// //if(num.ToString().Length = 3) Но всё со string - медленное
// if(num > 100 && num < 1000)
// {
//     int lastDigit = num % 10;
//     Console.WriteLine("Последняя цифра числа " + num + " это: " + lastDigit ); 
// }
// else
// {
//     Console.WriteLine("Число не трёхзначное");
// } 

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(num < 1000 && num > 99 ? num % 10: "Число не трёхзначное");