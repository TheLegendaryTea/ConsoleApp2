using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////это на тройку
            //try
            //{
            //    Console.WriteLine("введите x");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("введите y");
            //    int y = int.Parse(Console.ReadLine());
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("Точка в первой координатной четверти");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("Точка во второй координатной четверти");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("Точка в третьей координатной четверти");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("Точка в четвёртой координатной четверти");
            //    }
            //    else Console.WriteLine("ошибка");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                //1 2 2 2 1 2 (для проверки)
                Console.WriteLine("введите x1");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("введите y1");
                int y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("введите x2");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("введите y2");
                int y2 = int.Parse(Console.ReadLine());
                Console.WriteLine("введите x3");
                int x3 = int.Parse(Console.ReadLine());
                Console.WriteLine("введите y3");
                int y3 = int.Parse(Console.ReadLine());
                if ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3) == 0)
                {
                    Console.WriteLine("точки лежат на одной прямой");
                }
                else Console.WriteLine("точки не лежат на одной прямой");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
