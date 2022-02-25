using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Csh8_1
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        public string Desig { get; set; }
        public int Basic { get; set; }
    }
    class DemoProg
    {
        static void Main(String[] args)
        {
            //using (FileStream fs = new FileStream(@"D:\ang\SqlQuery1.sql", FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        string str = string.Empty;
            //        while((str=sr.ReadLine()) !=null)
            //        {
            //            Console.WriteLine(str);
            //        }
            //    }
            //}

             using FileStream fs1 = new FileStream(@"D:\ang\SqlQuery1.sql", FileMode.Open, FileAccess.Read);
            using StreamReader sr1 = new StreamReader(fs1);
            string str1 = string.Empty;
            while ((str1 = sr1.ReadLine()) != null)
            {
                Console.WriteLine(str1);
            }
        }
    }
}
