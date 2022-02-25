using System;
using System.IO;

namespace Csh8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(12,5));
            static int Sum(int x, int y) { return x + y; }

            static int Sub(int x, int y) => x - y;

            static int Mult(int x, int y) => x * y;

            Console.WriteLine(Sub(12,5));
            Console.WriteLine(Mult(12,5));
            Console.WriteLine("Hello World!");

            FileStream fs = new FileStream("c:\\hello.txt", FileMode.Open, FileAccess.Read);
            FileStream fs1 = new FileStream($@"c:\hello.txt", FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(@$"c:\hello.txt", FileMode.Open, FileAccess.Read); // C# 8 new one
           
            FileStream fs3 = new FileStream("c:/hello.txt", FileMode.Open, FileAccess.Read);
        }
    }
}
