// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Заполнение массива случайными цифрами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
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
void Print2DArray(int[,] matrix)
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

// Произведение двух матриц
int[,] ProductMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int row1 = firstMatrix.GetLength(0);
    int column1 = firstMatrix.GetLength(1);
    int row2 = secondMatrix.GetLength(0);
    int column2 = secondMatrix.GetLength(1);

    int[,] resultMatrix = new int[row1, column2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            int sum = 0;
            for (int k = 0; k < column1; k++)
            {
                sum = sum + firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

int[,] firstMatrix = Fill2DArray(2, 2, 10, 1);
int[,] secondMatrix = Fill2DArray(2, 2, 10, 1);
Console.Clear();
Print2DArray(firstMatrix);
Console.WriteLine();
Print2DArray(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = ProductMatrices(firstMatrix, secondMatrix);
Print2DArray(resultMatrix);