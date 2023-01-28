// №6. Написать программу, которая на вход принимает число и выдает, является ли число четным
// например:
// 4->да;
// 5->нет

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
 if (number1 % 2 == 0)
    {
        Console.WriteLine(number1 + " - Четное число. ");
    }
    else
    {
        Console.WriteLine(number1 + " - Нечетное число. ");
    
    }

