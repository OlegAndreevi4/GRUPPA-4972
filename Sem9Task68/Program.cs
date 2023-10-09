// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Функция Аккермана
static int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int res = Akkerman(m, n);
Console.WriteLine("Функция Аккермана равна " + res);