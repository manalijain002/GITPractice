using System;
using System.Collections.Generic;
using System.Text;

namespace Csh8Features
{
    public class StaticInner
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(12,5));
            static int Sum(int x,int y) { return x + y; }
        }
    }
}
