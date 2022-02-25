using System;
using System.Collections.Generic;
using System.Text;

namespace Csh8Features
{
    interface ICommSkills
    {
        void TimeTable();
        void TrainerName()
        {
            Console.WriteLine("Mr. Rajeev Taking Sessions...");
        }
    }
    interface IBankProider
    {
        void AcceptProofs();
        void HandOverDocuments();

        void BankName()
        {
            Console.WriteLine("From ICICI Bank...");
        }

        void Timings()
        {
            Console.WriteLine("From 9 to 6 only...");
        }
    }

    class Mphasis : IBankProider
    {
        public void AcceptProofs()
        {
            throw new NotImplementedException();
        }

        public void HandOverDocuments()
        {
            throw new NotImplementedException();
        }
    }
    class Capgemini : IBankProider, ICommSkills
    {
        public void AcceptProofs()
        {
            throw new NotImplementedException();
        }

        public void HandOverDocuments()
        {
            throw new NotImplementedException();
        }

        public void TimeTable()
        {
            throw new NotImplementedException();
        }
    }

    class Demo
    {
    }
}
