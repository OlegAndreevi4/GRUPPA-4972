// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//1) ReadData
//2) PrintResult
//3) DecToBin

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

string DecToBin(int num)
{
    string line = string.Empty; // String.Empty то же самое ""
    while( num > 0)
    {
        line = num%2 + line;
        num = num/2;
    }
    return line;
}

// Переводит число в двоичное
string DecToBinRec(int number)
{
    return number == 0 ? "" : DecToBinRec(number / 2) + Convert.ToString(number % 2);
}

int number = Prompt("Введите число: ");

Console.Write($"Двоичное представление числа(Simpl): {DecToBin(number)}");
Console.WriteLine();
Console.Write($"Двоичное представление числа(Recurent): {DecToBin(number)}");
Console.WriteLine();


//Alexandr

// String bin = Convert.ToString(a, 2);

// 21:31
// String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"), 2);
