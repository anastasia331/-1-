// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату точки x1: ");
long x1 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки у1: ");
long y1 = long.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату точки z1: ");
long z1 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки x2: ");
long x2 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки y2: ");
long y2 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки z2: ");
long z2 = long.Parse(Console.ReadLine()!);

long A= x2 - x1;
long B = y2 - y1;
 long C = z1 - z2;

double result = Math.Round(Math.Sqrt(A * A + B * B + C * C),2);
Console.WriteLine($"расстояние между точками {result}");


