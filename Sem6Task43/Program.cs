// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

int b = 0;
int k = 1;
int x = 0;
int y = 1;
int Line1 = 1;
int Line2 = 2;

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()??"";
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[b] = Prompt($"Введите b{numberOfLine}:");
    lineData[k] = Prompt($"Введите k{numberOfLine}:");
    return lineData;
}

double[] FindCoords(double[] straght1, double[] straght2)
{
    double[] coord = new double[2];
    coord[x] = (straght1[b] - straght2[b] / straght2[k] - straght1[k]);
    coord[y] = straght2[k] * coord[x] + straght2[b];
    return coord;
}

double[] straght1 = InputLineData(Line1);
double[] straght2 = InputLineData(Line2);
double[] coord = FindCoords(straght1, straght2);
Console.WriteLine("Точка пересечения прямых: (" + coord[x] +" , "+ coord[y] + ")");

//if (ValidateStraght(straght1, straght2))

// bool ValidateStraght(double[] straght1, double[] straght2)
// {
//     if (straght1[k] == straght2[k])
//     {
//         if (straght1[b] == straght2[b])
//         {
//             Console.WriteLine("Прямые совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны");
//             return false;
//         }
//     }
//     return true;
// }