//Задача № 30. Программа выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

//Ввод длины массива
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Метод генерации массива
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
        {
            arr[i] = rnd.Next(0, 2);
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
int[] res = GenArr(num);
PrintArray(res);