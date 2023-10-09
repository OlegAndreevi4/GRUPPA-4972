// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Сумма натуральных чисел
int SumNaturalNum(int m, int n)
{
  if (m == n) return m;
  else return m + SumNaturalNum(m + 1, n);
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int sum = SumNaturalNum(m, n);
Console.WriteLine("Сумма натуральных элементов равна " + sum);