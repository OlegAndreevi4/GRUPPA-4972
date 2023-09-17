// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
String line = (Console.ReadLine() ?? "0");
if (line.ToString().Length > 2)
{
    char[] digits = line.ToCharArray();
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}