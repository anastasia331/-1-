
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// например:
// 456->6
// 78-> третьей цифры нет!


Console.Write("Введите число: ");
int num =int.Parse(Console.ReadLine()); 
string num1 ="";
num1 = Convert.ToString(num);
if (num1.Length < 3) 
{
    Console.WriteLine("Во введённом числе третьей цифры нет!");
}
else Console.WriteLine($"Третья цифра введденного числа -> {num1[2]}");
