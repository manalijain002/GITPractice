using System;
using System.Collections.Generic;
using System.Text;

namespace Csh8Features
{
    class NullExamples
    {
        static void Main()
        {
            string? name = null;
            //name = "Girish";
            //Console.WriteLine(name);

            Employ e1 = new Employ();
            e1.Empno = 1;
            e1.Name = "Raghu";
            e1.Basic = 94922.44;

            Employ? employ = null;

            //if (name==null)
            //{
            //    name = "AKhil";
            //}
            name ??= "AKhil";
            Console.WriteLine(name);

            employ ??= e1;
            Console.WriteLine(employ);
        }
    }
}
