﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("введите количество строк m");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов n");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[linesVol, columnsVol];
FillArrayRandomNumbers(num);
PrintArray(num);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int a = 0; a < array.GetLength(1); a++)
        {
            array[i, a] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int a = 0; a < array.GetLength(1); a++)
        {
            Console.Write(array[i, a] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}



