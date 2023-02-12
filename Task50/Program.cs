// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Массив 4x4");
        Console.Write("Введите номер строки по счету для поиска: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца по счету для поиска: ");
        int n = Convert.ToInt32(Console.ReadLine());
        SearchArray(m, n);
    }

    static int SearchArray(int m, int n)
    {
        int x = 4;
        int y = 4;

        Random rand = new Random();
        int[,] array = new int[x, y];
        Console.WriteLine("Массив: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] = rand.Next(0, 10);
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"Результат поиска {m},{n}: ");
        if (((m - 1) < array.GetLength(0)) && ((n - 1) < array.GetLength(1)))
        {
            Console.WriteLine($"Значение элемента ({m},{n}) массива = {array[m - 1, n - 1]}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве");
        }
        return 1;
    }

}
