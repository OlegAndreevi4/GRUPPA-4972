// 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// 1) ReadData
// 2) Gen2DArr
// 3) Print2DArr
// 4) MinSumRaw

// Ввод данный
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Заполняет массив случайными цифрами
int[,] Gen2DArr(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

// Вывод массива
void Print2DArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Поиск строки с мин суммой
int MinSumRaw(int[,] arr2D)
{
    int outN = 0;
    int Sum = int.MaxValue;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        int sumRaw = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sumRaw = sumRaw + arr2D[i, j];
        }
        if (sumRaw < Sum)
        {
            Sum = sumRaw;
            outN = i+1;
        }
    }
    return outN;
}

// //Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int row = ReadData("введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 10, 1);
Console.Clear();
Print2DArr(arr2D);
int outN = MinSumRaw(arr2D);
Console.WriteLine();
PrintResult("Наименьшая сумма элементов в строке:" + outN);
