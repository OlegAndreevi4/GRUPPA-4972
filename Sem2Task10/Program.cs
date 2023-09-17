//№10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

//int firstDigit = number / 10

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");
if(num > 100 && num < 1000)
{
    int SecondDigit = (num % 100)/10;
    Console.WriteLine("Вторая цифра числа " + num + " это: " + SecondDigit ); 
}
else
{
    Console.WriteLine("Число не трёхзначное");
}