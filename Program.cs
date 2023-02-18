using System;

namespace Struct16._02._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Vector obj = new Vector(4,5,6);
            obj.Umn(3);
            obj.Print();
            Console.WriteLine("\n");
            Vector obj1 = new Vector(4, 5, 6);
            obj1.Summ(3);
            obj1.Print();
            Console.WriteLine("\n");
            Vector obj0 = new Vector(3, 2, 3);
            Vector obj2 = new Vector(7, 6, 9);
            obj2.VectoMinus(obj0);
            obj2.Print();
        }

        
    }
}
