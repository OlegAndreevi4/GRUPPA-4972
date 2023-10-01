using System;

class Program
{
static void Main()
{
var b1 = 2;
var k1 = 5;
var b2 = 4;
var k2 = 9;

    var xInterval = new double[] { 0, 1 };
    var y1 = LinearFunction(k1, b1, xInterval[0]);
    var y2 = LinearFunction(k2, b2, xInterval[0]);

    if (y1 != y2)
    {
        Console.WriteLine("Прямые не пересекаются");
        return;
    }

    double xGuess = xInterval[0];
    while (xGuess < xInterval[1])
    {
        var y1New = LinearFunction(k1, b1, ++xGuess);
        var y2New = LinearFunction(k2, b2, ++xGuess);

        if (y1New == y2New)
        {
            Console.WriteLine($"Точка пересечения прямых:({xGuess}, {y1New})");
        }   
    return;
}
}
}

static double LinearFunction(double k, double b, double x)
{
    return k * x + b;
}
