// Задача №18
//Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (x и y)

// 1)Ввести номер четверти -> ReadData() 
// 2) ответить на вопрос -> ? 
// 3) вывести ответ -> PrintResult() 

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//По номеру четверти определяем диапозон возможных координат
string QuterBorderAsk(int numQuter)
{
    if (numQuter == 1) return "x > 0, y > 0";
    if (numQuter == 2) return "x > 0, y < 0";
    if (numQuter == 3) return "x < 0, y < 0";
    if (numQuter == 4) return "x < 0, y > 0";
    return string.Empty;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQuter = ReadData("Введите номер четверти: ");

string res = QuterBorderAsk(numQuter);

PrintResult("Диапозон возможных координат: " + res);