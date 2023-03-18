using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._3
{
    public class Student
    {

        public string name { get; set; }

        public void Study()
        {
            Console.WriteLine("Study From Student");
        }

        public void Read()
        {
            Console.WriteLine("Read From Student");
        }

        public void Write() 
        {
            Console.WriteLine("Write From Student");
        }

        public void Relax()
        {
            Console.WriteLine("Relax From Student");
        }


    }

    public class LazyStudent : Student 
    {
        public void Study()
        {
            Console.WriteLine("Study From Lazystudent");
        }
    }

    public class GoodStudent : Student
    {
      public void Read()
        {
            Console.Write("Write From Goodstudent");
        }
    }
}
