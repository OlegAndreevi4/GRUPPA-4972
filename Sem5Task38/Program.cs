// 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

//Метод генерации массива
double[] GenArr(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() + rnd.Next(-10, 10)), 5);
    }
    return array;
}

//Вывод массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Поиск минимакса
(double, double) MaxMinValue(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return (min,max);
}

double[] res = GenArr(10);
Console.WriteLine();
PrintArray(res);
(double min, double max) Value =MaxMinValue(res);
Console.WriteLine("Максимальное число в массиве: "+ Value.max);
Console.WriteLine("Минимальное число в массиве: "+ Value.min);
Console.WriteLine ("Разница чисел: " + Math.Round((Value.max - Value.min),5));