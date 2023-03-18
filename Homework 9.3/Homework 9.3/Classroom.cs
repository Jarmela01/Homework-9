using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._3
{
    public class Classroom
    {
        public Classroom()
        {
            Student student = new Student();
            student.Write();
            student.Relax();
            student.Read();
            student.Study();
            GoodStudent goodStudent = new GoodStudent();
            goodStudent.Read();
            LazyStudent lazyStydent = new LazyStudent();
            lazyStydent.Study();
        }
    }
}
