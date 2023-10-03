// int n = 3;
// int m = 4;
// int k = 2;

// void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//     int[,] array2D = new int[n, m];
//     array2D[0,0] =1;
//     for (int i = 1; i < n; i++)
//     {
//         for (int j = 1; j < m; j++)
//         {
//             array2D[i,j] = array2D[i,j] + k;
//         }
//     }
//     return array2D;
// }

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        int elem = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = elem;
                elem += k;
            }
        }
        return matrix;

    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] results = new int[2];
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        if (rowPosition <= n && columnPosition <= m)
        {
            results[0] = matrix[rowPosition - 1, columnPosition - 1];
            results[1] = 0;
        }
        else { results = new int[1] { 0 }; }
        return results;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results.Length == 2)
        {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
        else
        {
            Console.WriteLine("There is no such index");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
            x = 2;
            y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}