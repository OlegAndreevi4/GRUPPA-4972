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



// //------------------------------------------------------------------------------------------------------------------
// //                                                  Задача 34
// //                                      Домашнее задание к семинару 05
// //   Задайте массив, заполненный случайными положительными трёхзначными числами
// //   Напишите программу, которая покажет количество чётных чисел в массиве.
// //   * Отсортировать массив методом пузырька
// //------------------------------------------------------------------------------------------------------------------

// //                                                 Тело программы
// //------------------------------------------------------------------------------------------------------------------
// Console.Clear();

// // Генерация массива из случайных чисел и вывод 
// int[] array = GenerateRandomArray(10, 100, 999);
// PrintArray("Исходный массив:\n", array);

// //Подсчет четных чисел в массиве и вывод результата
// int evenCount = CountEvenNumbers(array);
// PrintResult($"Количество четных элементов в массиве: {evenCount}");

// // Сортировка массива методом пузырька и вывод
// BubbleSort(array);
// PrintArray("Отсортированный массив:\n", array);

// //                                                     Методы
// //------------------------------------------------------------------------------------------------------------------
// // Генерация массива
// int[] GenerateRandomArray(int length, int minValue, int maxValue)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
//     return array;
// }

// //Подсчет четных чисел в массиве
// int CountEvenNumbers(int[] array)
// {
//     int count = 0;
//     foreach (int num in array)
//     {
//         if (num % 2 == 0) { count++; }
//     }
//     return count;
// }

// // Вывод результата
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// // Сортировка методом пузырька
// void BubbleSort(int[] array)
// {
//     int n = array.Length;
//     for (int i = 0; i < n - 1; i++)
//         for (int j = 0; j < n - i - 1; j++)
//             if (array[j] > array[j + 1])
//             {
//                 // Меняем местами элементы
//                 int temp = array[j];
//                 array[j] = array[j + 1];