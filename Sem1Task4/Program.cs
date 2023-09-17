//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите три числа");
int numb1 = Convert.ToInt32(Console.ReadLine());
int numb2 = Convert.ToInt32(Console.ReadLine());
int numb3 = Convert.ToInt32(Console.ReadLine());
int max = numb1;
if(numb2 > max) max = numb2;
if(numb3 > max) max = numb3;
Console.Write("Максимальное число ");
Console.Write(max);
