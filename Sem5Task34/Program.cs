// 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

//Метод генерации массива
int[] GenArr(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

//Вывод массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Счётчик количества
int Counter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    return count;
}

//Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int[] res = GenArr(4);
PrintArray(res);
int count = Counter(res);
PrintResult("Количествво чётных чисел в массиве равно: " + count);