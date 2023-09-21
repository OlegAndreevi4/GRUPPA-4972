// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}



//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


//1) вввод числа от пользователя
//2) вычисление суммы
//3) вывод результата

int SimpleSum(int numA)
{
    int SumOfNumber = 0;
    for (int i = 1; i < numA; i++)
    {
        //SumOfNumber =SumOfNumber + i;
        SumOfNumber+=i;
    }
    return SumOfNumber;
}

int numberA = ReadData("Ввведите число А: ");

int res = SimpleSum(numberA);

PrintResult("Сумма чисел от 1 до "+ numberA + " равна " + res);
