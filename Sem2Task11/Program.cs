// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//1 Способ
int Num = new Random().Next(100, 1000);
Console.WriteLine(Num);
int num = Convert.ToInt32(Num);
Console.WriteLine((num / 100) * 10 + (num % 10));

//2 Способ
// int ran = new System.Random().Next(100, 1000);
// System.Console.WriteLine(ran);
// char[] digitChar = ran.ToString().ToCharArray();
// System.Console.Write(digitChar[0]);
// System.Console.Write(digitChar[2]);
