using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDree1.vidAss
{
    class Consultancy
    {
        static void Main(string[] args)
        {
            Student Amit = new Student();
            Amit.Sname = "Amit Gunnam";
            Amit.RegNo = 576578787;
            Amit.consultanc = "babai";

            Student Murali = new Student();
            Murali.Sname = "Murali Godi";
            Murali.RegNo = 3157317513;
            Murali.consultanc = "vsoft or siri";
            Course networking = new Course();
            networking.Cname = "networking" ;
            Course jigb = new Course();
            jigb.Cname = "jigb";
            Course Cloud = new Course();
            Cloud.Cname = "Cloud";

            Murali.courses = new List<Course>();
            Murali.courses.Add(networking);
            Murali.courses.Add(jigb);
            Murali.courses.Add(Cloud);

            
            Student bakka = new Student();
            bakka.Sname = "Viajy Bhargav";
            bakka.RegNo = 65646764678468;
            bakka.consultanc = "siri";
           
            Course python = new Course();
            python.Cname = "python ";
            Course coreJava = new Course();
            coreJava.Cname = "coreJava";

            bakka.courses = new List<Course>();
            bakka.courses.Add(python);
            bakka.courses.Add(coreJava);

            Student kitty = new Student();
            kitty.Sname = "Krishna vankadari";
            kitty.RegNo = 3158011244;
            kitty.consultanc = "coedec";

            Course dotnet = new Course();
            dotnet.Cname = "dotnet";

            kitty.courses = new List<Course>();
            kitty.courses.Add(dotnet);
            kitty.courses.Add(jigb);
            kitty.courses.Add(coreJava);

            List<Student> studList = new List<Student>();
          //  studList.Add(Amit);
            studList.Add(Murali);
            studList.Add(bakka);
            studList.Add(kitty);

            foreach(var x in studList)
            {
                Console.WriteLine(x.Sname);
                Console.WriteLine(x.consultanc);
                Console.WriteLine(x.RegNo);

                if (x.courses.Count>0)
                {
                    foreach(var c in x.courses)
                    {
                        Console.WriteLine(c.Cname);
                    }
                }
                else
                {
                    Console.WriteLine("Yoo!!! choose a F34y crse");
                }
            }
            Console.ReadLine();





        }
    }
}
