Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()); 
int start = 1;
while (start<=N) 
    {
         if (start % 2 ==0)
         {
            Console.Write(start + ", ");
         }
     ++start;
    }
