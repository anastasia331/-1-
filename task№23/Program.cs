﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("введите целое число: ");
int userInput = int.Parse(Console.ReadLine()!);
int counter =1;
while (counter < userInput)
{
    Console.Write($"{counter*counter*counter}, ");
    counter++;
}
Console.Write($"{counter*counter*counter} ");

