// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату x1 ");
long x1 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1 ");
long y1 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1 ");
long z1 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x2 ");
long x2 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2 ");
long y2 = long.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2 ");
long z2 = long.Parse(Console.ReadLine());
long length;

if ((x1>0) &&  (x2>0))
{
    if(x1>x2)
    {
     length = x1 - x2;
    }
     else
     {
        length = x2 - x1;
     }
}
       else if ((x1<0) && (x2<0))
       {
     if(x1>x2)
     {
     length = x2 - x1;
    }
    else
    {
        length = x1- x2;
    }
       }
       else
       {
       if(x1>x2)
     {
     length = x2 - x1;
    }
    else
    {
        length = x2- x1;
    }
       }
    long width;
    if ((y1>0) &&  (y2>0))
{
    if(y1>y2)
    {
     width = y1 - y2;
    }
     else
     {
        width = y2 - y1;
     }
}
       else if ((y1<0) && (y2<0))
       {
     if(y1>y2)
     {
     width = y2 - y1;
    }
    else
    {
        width = y1- y2;
    }
       }
       else
       {
       if(y1>y2)
     {
    width = y2 - y1;
    }
    else
    {
        width = y2- y1;
    }
       }
    
    long heidht;
    if ((z1>0) &&  (z2>0))
{
    if(z1>z2)
    {
     heidht = z1 - z2;
    }
     else
     {
        heidht = z2 - z1;
     }
}
       else if ((z1<0) && (z2<0))
       {
     if(z1>z2)
     {
     heidht= z2 - z1;
    }
    else
    {
       heidht = z1- z2;
    }
       }
       else
       {
       if(z1>z2)
     {
    heidht = z2 - z1;
    }
    else
    {
        heidht = z2- z1;
    }
       }
    
double result = Math.Round(Math.Sqrt(length*length+width*width+heidht*heidht),3);
Console.WriteLine($"расстояние между точками {result}");