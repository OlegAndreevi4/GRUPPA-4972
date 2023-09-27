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