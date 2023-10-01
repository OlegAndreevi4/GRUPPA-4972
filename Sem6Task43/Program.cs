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


﻿// //№43* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// //1 0,-1 2,0 0 — Должно получиться ~1
// //(Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых 

// Line ReadParameters(string msg) //На вход принимаем коэффициенты k и b — они образуют объект класса Line(описан внизу)
// {
//     Console.WriteLine(msg);
//     string initialString = Console.ReadLine() ?? "0";
//     initialString = (initialString.TrimEnd()).TrimStart(); //Удаляем пробелы в начале и конце строки,если они есть.
//     string[] points = initialString.Split(' '); //Разбиваем входящую строку по пробелу на несколько строк.
//     points = Array.FindAll(points, isNotEmpty).ToArray(); //Если случайно ввели лишний пробел — исправляем.
//     Line line = new Line();
//     line.k = Convert.ToDouble(points[0]);
//     line.b = Convert.ToDouble(points[1]);
//     return line;
// }

// bool isNotEmpty(string n) //Вспомогательный метод для нахождения непустых элементов массива строк
// {
//     return !n.Equals(String.Empty);
// }

// Line lineA = ReadParameters("Введите коэффициенты первой прямой через пробел"); //читаем коэффициенты
// Line lineB = ReadParameters("Введите коэффициенты второй прямой через пробел");
// Line lineC = ReadParameters("Введите коэффициенты третьей прямой через пробел");
// Triangle triangle = new Triangle(); //"Создаём" треугольник и ниже проверяем,не являются ли какие-либо из 
//                                     //прямых параллельными
// if (triangle.IsNotPossible(lineA, lineB, lineC)) { Console.WriteLine("Такой треугольник невозможен"); Environment.Exit(0); }
// Point intersectAB = triangle.CrossPoint(lineA, lineB); //point B на плоскости
// Point intersectAC = triangle.CrossPoint(lineA, lineC); //point A на плоскости
// Point intersectBC = triangle.CrossPoint(lineB, lineC); //point C на плоскости
// double sideAB = triangle.SideLength(intersectAB, intersectAC); //Вычисляем длины сторон
// double sideAC = triangle.SideLength(intersectAC, intersectBC);
// double sideBC = triangle.SideLength(intersectAB, intersectBC);
// double sq = triangle.Square(sideAB, sideBC, sideAC); //Считаем площадь через 3 стороны и полупериметр
// Console.WriteLine("Площадь треугольника равна " + sq);

// public class Triangle //Все вычисления проводятся в этом классе
// {
//     //Проверка,что нет параллельных прямых 
//     public bool IsNotPossible(Line lineone, Line linetwo, Line linethree)
//     {
//         return (lineone.k == linetwo.k) || (lineone.k == linethree.k) || (linetwo.k == linethree.k);
//     }
//     //Считаем точки пересечения
//     public Point CrossPoint(Line lineone, Line linetwo)
//     {
//         Point crspoint = new Point();
//         crspoint.x = (linetwo.b - lineone.b) / (lineone.k - linetwo.k); // 
//         crspoint.y = lineone.k * crspoint.x + lineone.b;
//         return crspoint;
//     }

//     //Считаем стороны треугольника
//     public double SideLength(Point crspointA, Point crspointB)
//     {
//         return Math.Sqrt(Math.Pow((crspointB.x - crspointA.x), 2) + Math.Pow((crspointB.y - crspointA.y), 2));
//     }
//     //Считаем площадь через полупериметр
//     public double Square(double sideA, double sideB, double sideC)
//     {
//         double perimeter = 0;
//         double square = 0;
//         perimeter = (sideA + sideB + sideC) / 2;
//         square = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
//         return square;
//     }
// }
// public class Line //Прямые линии (kx+b)
// {
//     public double k, b = 0; //Коэффициенты прямой
// }

// public class Point 
// {
//     public double x, y = 0; //Точка на плоскости
// }

// * Найдите площадь треугольника образованного пересечением 3 прямых 
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем