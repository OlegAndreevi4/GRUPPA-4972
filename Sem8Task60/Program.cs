// 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Генерация массива случайных двухзначных чисел
int[,,] Fill3DArray(int row, int column, int layer)
{
    System.Random numberGenerator = new System.Random();
    int[,,] array3D = new int[row, column, layer];
    int number = numberGenerator.Next(10, 100);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < layer; k++)
            {
                array3D[i, j, k] = number;
                number = numberGenerator.Next(10, 100) + 1;
            }
        }
    }
    return array3D;
}

// Вывод массива с индексами
void Print3DArray(int[,,] array3D)
{
    for (int k = 0; k < array3D.GetLength(0); k++)
    {
        for (int i = 0; i < array3D.GetLength(1); i++)
        {
            for (int j = 0; j < array3D.GetLength(2); j++)
            {
                Console.Write(array3D[i, j, k]+ "("+i+","+j+","+k+") ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3D = Fill3DArray(2, 2, 2);
Print3DArray(array3D);