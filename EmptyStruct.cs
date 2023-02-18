using System;
namespace Struct16._02._2023HM
{
    public struct Vector
    {
        public int a;
        public int b;
        public int c;

       
        public Vector(int A, int B, int C)
        {
            a = A;
            b = B;
            c = C;
        }

        public void Umn(int r)
        {
            Console.WriteLine("Результат умножения вектора на число");
            a *= r;
            b *= r;
            c *= r;
        }
        public void Summ(int r)
        {
            Console.WriteLine("Результат сумирования вектора и числа");
            a += r;
            b += r;
            c += r;
        }
        public void VectoMinus(Vector A)
        {
            Console.WriteLine("Результат разницы двух векторов");
            a -= A.a;
            b -= A.b;
            c -= A.c;
        }
        public void Print()
        {
            Console.WriteLine($"A = {a}\tB = {b}\tC = {c}\t");
        }
        public override string ToString()
        {
            return $"A{a}\tB{b}\tC{c}\t";
        }

    }
   

    
}