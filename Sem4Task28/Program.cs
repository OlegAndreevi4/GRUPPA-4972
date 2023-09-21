// // Задача №28 Программа принимает число N и выдаёт произведение чисел от 1 до N.

// //Вводим данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine()??"0");
//     return num;
// }

// long Factorial(int num)
// {
//     long res = 1;
//     for( int i = 2; i <= num; i++)
//     {
//         res = res * i;
//     }
//     return res;
// }

// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int numberA = ReadData("Ввведите число А: ");

// long res = Factorial(numberA);

// // PrintResult($"Произведение чисел равно {res}"); ТО ЖЕ САМОЕ
// PrintResult("Произведение чисел равно " +res);

using System.Numerics;

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Считаем цифры
BigInteger CountFact(int num)
{
    BigInteger fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int num = ReadData("Введите целое число: ");
BigInteger fact = CountFact(num);
PrintResult("Факториал числа " + num + " равен " + fact);