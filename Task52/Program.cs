// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int y = Convert.ToInt32(Console.ReadLine());
        AverageArray(x, y);
    }

    static int AverageArray(int x, int y)
    {
        Random rand = new Random();
        int[,] array = new int[x, y];
        double[] sumcolarray = new double[y];
        Console.WriteLine("Массив: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] = rand.Next(0, 10);
                sumcolarray[j] += (double)array[i, j] / x;
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write($"Cреднее арифметическое по столбцам: ");
        foreach (double item in sumcolarray)
        {
            Console.Write("{0,5:f3} ", item);
        }

        return 1;
    }

}