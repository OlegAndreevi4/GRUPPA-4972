// 26: Программа принимает число и выдаёт количество цифр в числе.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int NumDigits( int num)
{
    int count = 0;
    while(num >0)
    {
        count ++;
        num=num/10;
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numberA = ReadData("Ввведите число А: ");

int res = NumDigits(numberA);

PrintResult("Количество цифр в числе равно " + res);

