// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер:");
int day = int.Parse(Console.ReadLine() ?? "0");
if (day > 7)
{
    Console.WriteLine("Не является днём недели");
}
else
{
    string[] dayOfWeek = new string[7];

    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

Console.Write(dayOfWeek[day - 1]);
}
if (day == 6 || day == 7)
{
    Console.WriteLine(" - это выходной");
}