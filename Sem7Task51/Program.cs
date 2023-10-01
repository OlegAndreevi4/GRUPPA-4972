// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


// 1)ReadData
// 2)Print2DArray
// 3)Fill2DArray
// 4)PrintData
// 5) MainDiagSum


// int MainDiagSum(int[,] mtrx)
// {
//     int res = 0; 
//     int min = mtrx.GetLength(0); //мин - количество столбцов(те элементов в строке)
//     if(min> mtrx.GetLength(1))min = mtrx.GetLength(1);//если мин больше чем колво строк(длина массива по-вертикали), то в мин кладём колво строк)
//     for(int i =0; i < min; i++)
//     {
//         res = res + mtrx[i,i];
//     }
//     return res; // сумма элементов
// }


﻿// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void Random2DArray(int[,] array, int minElement, int maxElement)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minElement, maxElement);
}
// Ищет элементы, у которых оба индекса чётные и меняет их
int MainDiagonalSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int minElement = 0;
int maxElement = 10;

int[,] array = new int[m, n];
Random2DArray(array, minElement, maxElement);
Output2DArray(array, "Массив: ");

Console.WriteLine("Сумма эл-тов главной диагонали: " + MainDiagonalSum(array));