﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int nam= number.Length;

if (nam == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} -> число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} -> число не является палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} число не является пятизначныи!");
}

