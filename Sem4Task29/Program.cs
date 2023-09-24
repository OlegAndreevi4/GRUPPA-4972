// 29: Программа задаёт массив из 8 элементов и выводит их на экран.

void OutArray8()
{
    //Метод генерации массива
    int[] GenArr(int len)
    {
        int[] arr = new int[len];
        Random rnd = new Random();
        for (int i = 0; i < len; i++)
        {
            arr[i] = rnd.Next(0, 100);
        }
        return arr;
    }

    //Вывод массива
    void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1] + "]");
    }

    //int num = ReadData("Ввведите длину массива: ");
    int[] res = GenArr(7);
    PrintArray(res);
}

// 29.1 Ввести с клавиатуры длину массива и диапазон значений элементов.

void OutGivenArray()
{
//Ввод длины массива
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Ввод меньшего значения
int ReadData1(string msg)
{
    Console.WriteLine(msg);
    int lowBorder = int.Parse(Console.ReadLine() ?? "0");
    return lowBorder;
}

//Ввод большего значения
int ReadData2(string msg)
{
    Console.WriteLine(msg);
    int highBorder = int.Parse(Console.ReadLine() ?? "0");
    return highBorder;
}

//Генерация массива
int[] GenArr(int len, int lowBorder, int highBorder)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return arr;
}

//Вывод массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int num = ReadData("Ввведите длину массива: ");
int lowBorder = ReadData1("Ввведите нижнюю границу диапозона: ");
int highBorder = ReadData2("Ввведите верхнюю границу диапозона: ");
int[] res = GenArr(num, lowBorder, highBorder);
Console.WriteLine();
PrintArray(res);
}

Console.WriteLine();
OutArray8();
Console.WriteLine();
OutGivenArray();
