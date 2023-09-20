// Задача 23: Программа принимает число (N) и выдаёт таблицу кубов чисел от 1 до N.

public class Answer
{
   static void ShowCube(int N)
    {
    Console.WriteLine("");
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3) + "");
    }
    Console.WriteLine();    
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 10;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}