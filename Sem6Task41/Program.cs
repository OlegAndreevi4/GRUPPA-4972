// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Вывод сообщения и запись данных
int[] Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? " ";
    return StringToIntArray(value);
}

// Преобразование строки в массив чисел
int[] StringToIntArray(string value)
{
    string[] values = value.Split(" ");
    int[] Array = new int[values.Length];
    for (int i = 0; i < values.Length; i++)
    {
        Array[i] = Convert.ToInt32(values[i]);
    }
    return Array;
}

//Подсчёт количества чисел > 0
int CountPositivNumber(int[] Array)
{
    int Count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            Count++;
        }
    }
    return Count;
}

// //Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] Array = Prompt("Введите числа через пробел: ");
int NumberPosValues = CountPositivNumber(Array);
PrintResult(NumberPosValues + " чисел больше 0 ввёл пользователь.");


// void AnnasVariant()
{
// ﻿//------------------------------------------------------------------------------------------------------------------
// //                                                  Задача 41
// //                                          Домашнее задание к семинару 06
// //   Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// //   (*) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.
// //------------------------------------------------------------------------------------------------------------------

// //                                                 Тело программы
// //------------------------------------------------------------------------------------------------------------------
// using System.Text.RegularExpressions;
// Console.Clear();

// int numOfKeyPresses = ReadInt("Введите количество нажатий: ");  // Ввод пользователем количества нажатий.
// string data = KeyPresses("Введите строку: ", numOfKeyPresses);  // Получение нажатий с клавиатуры.
// //Console.WriteLine(data);
// int count = CountPositiveNumbers(data);                         // Подсчет положительных чисел в строке.
// PrintResult($"\nВведено чисел больше нуля: {count}");           // Вывод результата в консоль.

// //                                                     Методы
// //------------------------------------------------------------------------------------------------------------------

// // Ввод целого числа с клавиатуры.
// int ReadInt(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Получение нажатий с клавиатуры.
// string KeyPresses(string msg, int numOfKeyPresses)
// {
//     Console.Write(msg);
//     string data = string.Empty;
    
//     for (int i = 0; i < numOfKeyPresses; i++)
//     {
//         var keyInfo = Console.ReadKey();
//         data += keyInfo.KeyChar;
//     }

//     return data;
// }

// // Подсчет положительных чисел в строке с использованием регулярных выражений.
// int CountPositiveNumbers(string input)
// {
//     string pattern = @"[-]?[0-9]+";
//     MatchCollection matches = Regex.Matches(input, pattern);

//     int count = 0;
//     foreach (Match match in matches)
//     {
//         if (int.Parse(match.Value) > 0) { count++; }
//     }
//     return count;
// }

// // Вывод результата в консоль.
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }
}