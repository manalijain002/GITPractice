using System;

namespace Csh8Features
{
    interface IOne
    {
        void Name();
        void Company()
        {
            Console.WriteLine("Company is Capgemini...");
        }
    }

    abstract class Sports
    {
        public abstract void Score();
    }

    class Akhil : Sports, IOne
    {
        public void Name()
        {
            throw new NotImplementedException();
        }

        public override void Score()
        {
            throw new NotImplementedException();
        }
    }
    abstract class Training : IOne
    {
        public void Name()
        {
            Console.WriteLine("From Training...");
        }
    }

    class Test : IOne
    {
        public void Name()
        {
            Console.WriteLine("Name from test Class...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOne ob = new Test();
            ob.Company();
        }
    }
}
