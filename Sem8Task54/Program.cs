// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// 1) ReadData
// 2) Gen2DArr
// 3) Print2DArr
// 4) SortArr

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
void Print2DArr(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(arr2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Сортировка массива
void SortArr(int[,] arr)
{
    int[] buf = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buf[j] = arr[i, j];
        }
        int n = arr.Length; //Сортировка пузырьком
        int temp = 0;
        for (int z = 0; z < arr.GetLength(1); z++)
        {
           for (int j = 0; j < n - i - 1; j++)
            {
                if (buf[j] > buf[j + 1])
                {
                    temp = buf[j];
                    buf[j] = buf[j + 1];
                    buf[j + 1] = temp;
                }
            }
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = buf[j];
        }
    }

}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 10, 1);
Print2DArr(arr2D);
SortArr(arr2D);
Print2DArr(arr2D);

