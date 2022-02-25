using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employ> employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Raj",Dept="Dotnet",Desig="Programmer",Basic=88422},
                new Employ{Empno=2,Name="Anubhav",Dept="Asp.net",Desig="Expert",Basic=90422},
                new Employ{Empno=3,Name="Manali",Dept="Angular",Desig="Manager",Basic=91122},
                new Employ{Empno=4,Name="Prathyusha",Dept="C#",Desig="Tester",Basic=89044},
                new Employ{Empno=5,Name="Kiran",Dept="ASP",Desig="Designer",Basic=98423},
                new Employ{Empno=6,Name="Akhil",Dept="VB",Desig="Programmer",Basic=89853},
            };

            List<LeaveDetails> leaveDetailsList = new List<LeaveDetails>()
            {
                new LeaveDetails{LeaveId=1,Empno=1,LeaveTaken=2,LossOfPay=5833.44},
                new LeaveDetails{LeaveId=2,Empno=1,LeaveTaken=3,LossOfPay=8855},
                new LeaveDetails{LeaveId=3,Empno=2,LeaveTaken=5,LossOfPay=9443.44},
                new LeaveDetails{LeaveId=4,Empno=2,LeaveTaken=4,LossOfPay=8733.44},
                new LeaveDetails{LeaveId=5,Empno=3,LeaveTaken=1,LossOfPay=7845.44},
                new LeaveDetails{LeaveId=6,Empno=4,LeaveTaken=1,LossOfPay=7643.44},
            };
            Console.WriteLine("Employ Records are  ");
            var result1 = from ob in employList select ob;
            foreach(var v in result1)
            {
                Console.WriteLine("Employ No  " +v.Empno);
                Console.WriteLine("Employ Name  " +v.Name);
                Console.WriteLine("Department  " +v.Dept);
                Console.WriteLine("Designation " +v.Desig);
                Console.WriteLine("Basic  " +v.Basic);
                Console.WriteLine("--------------------------");
            }

            var result2 = from ob in employList select new {ob.Empno, ob.Name,ob.Basic };

            Console.WriteLine("Employ Projected Records  ");
            foreach(var v in result2)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Basic  " + v.Basic);
                Console.WriteLine("--------------------------");
            }

            // Display records whose basic > 90000

            var result3 = from ob in employList where ob.Basic >= 90000 select ob;
            Console.WriteLine("Filtered Records are ");
            foreach (var v in result3)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department  " + v.Dept);
                Console.WriteLine("Designation " + v.Desig);
                Console.WriteLine("Basic  " + v.Basic);
                Console.WriteLine("--------------------------");
            }

            var result4 = from ob in employList orderby ob.Name select ob;
            Console.WriteLine("Sorted Data  ");
            foreach(var v in result4)
            {
                Console.WriteLine("Employ No  " + v.Empno);
                Console.WriteLine("Employ Name  " + v.Name);
                Console.WriteLine("Department  " + v.Dept);
                Console.WriteLine("Designation " + v.Desig);
                Console.WriteLine("Basic  " + v.Basic);
                Console.WriteLine("--------------------------");
            }

            var joinData = from em in employList
                           join ld in leaveDetailsList on
     em.Empno equals ld.Empno
                           select new
                           {
                               em.Empno,em.Name,em.Basic,ld.LeaveId,ld.LeaveTaken,ld.LossOfPay
                           };

            Console.WriteLine("Joined Data is  ");
            foreach(var v in joinData)
            {
                Console.WriteLine("Employ No  " +v.Empno);
                Console.WriteLine("Employ Name   " +v.Name);
                Console.WriteLine("Basic   " +v.Basic);
                Console.WriteLine("Leave id  " +v.LeaveId);
                Console.WriteLine("Leave Taken  " +v.LeaveTaken);
                Console.WriteLine("Loss Of Pay  " +v.LossOfPay);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
