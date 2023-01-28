// № 2. Написать программу, которая на вход принимает числа и выдает, какое число больше, а какое меньше.
// Напрмер:
// a = 5; b = 7 -> max 7;
// a = 2; b = 10 -> max 10;
// a = -9; b = -3 ->  max -3;

Console.WriteLine ("введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine ("введите второе число ");
int number2 = int.Parse(Console.ReadLine());
 if (number1 == number2)
   {
        Console.WriteLine(number1+ "=" + number1);
    }
    else
    
      if (number1 > number2)
    {
        Console.WriteLine("max: " + number1);
        Console.WriteLine("min: " + number2);
    }
    else
  if (number1 < number2)
    {
        Console.WriteLine("max: " + number2);
        Console.WriteLine("min: " + number1);
    }
    
