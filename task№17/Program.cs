/*напишите программу, котрая принимает на вход координаты точки (Х и Y), причем X и Y  не равны 0 
и выдает номер четверти плоскости, в которой находится это точка */

console.Write("Введите x: ");
int X  = int.Parse(console.ReadLine);
console.Write("Введите y: ");
int Y = int.Parse(console.ReadLine);
if (X>0 && Y>0)
{
    Console.Writeline("первая четверть");
}
if (X<0 && Y>0)
{
    Console.Writeline("вторая четверть")
