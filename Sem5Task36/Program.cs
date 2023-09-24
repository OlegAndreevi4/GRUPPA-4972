// 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//Метод генерации массива
int[] GenArr(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
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

//Сумма чисел
int SumOddNumber(int[] arr)
{
    int Sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        Sum = Sum + arr[i];
    }
    return Sum;
}

//Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] res = GenArr(10);
PrintArray(res);
int SumOfDigits = SumOddNumber(res);
PrintResult("Сумма элементов, стоящих на нечётных позициях равна: " + SumOfDigits);