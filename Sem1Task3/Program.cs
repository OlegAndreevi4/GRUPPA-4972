// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

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

Console.WriteLine(dayOfWeek[day - 1]);
}

// Console.WriteLine("Enter day nuber");
// int dayNum = int.Parse(Console.ReadLine());

// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo(ru-Ru).DateTimeFormat.GetDayName(typeof(DayOfWeek))
