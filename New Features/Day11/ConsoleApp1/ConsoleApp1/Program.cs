using System;

namespace ConsoleApp1
{
    interface IWriteLine
    {
        public void WriteLine()
        {
            Console.WriteLine("Wow C# 8!");
        }
    }

    class Hello : IWriteLine
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            IWriteLine obj = new Hello();
            obj.WriteLine();
            Console.WriteLine("Hello World!");
        }
    }
}
