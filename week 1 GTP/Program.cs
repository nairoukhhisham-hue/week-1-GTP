using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_GTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello World");

            String x = "Hisham ";

            int age1  = 21;

            double courseDuration1 = 4.8;

            String y =" omar " ;

            int age2 = 22;

            double courseDuration2 = 5.8;
            Console.WriteLine("Traineers information ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Traineer 1 : ");
            Console.WriteLine("Name : "+ x);

            Console.WriteLine("Age : "+ age1);

            Console.WriteLine("Cours Duraion :" + courseDuration1);
            Console.WriteLine("Traineer 2 : ");
            Console.WriteLine("Name : " +y);

            Console.WriteLine("Age : " + age2);

            Console.WriteLine("Cours Duraion :" + courseDuration2);

        }
    }
}
