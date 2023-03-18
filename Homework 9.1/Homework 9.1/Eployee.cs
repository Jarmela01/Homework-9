using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._1
{
    public class Eployee
    {

        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public int[] hours { get; set; }

        public double shemosavali { get; set; }

        public void InCome(string position, int[] hours)
        {

            double income = 0;
            int hoursSum = 0;                      

            for (int i = 0; i < hours.Length; i++)
            {
                hoursSum += hours[i];
                
                if (position == "manager")
                {                   
                    if (i < 5)
                    {
                        income += hours[i] * 40;
                    }

                    else
                    {
                        income += hours[i] * 40 * 2;
                    }
                }
                
                if (position == "developer")
                {
                    if (i < 5)
                    {
                        income += hours[i] * 30;
                    }

                    else
                    {
                        income += hours[i] * 30 * 2;
                    }
                }
              
                if (position == "tester")
                {
                    if (i < 5)
                    {
                        income += hours[i] * 20;
                    }

                    else
                    {
                        income += hours[i] * 20 * 2;
                    }
                }                

                if (position != "tester" && position != "developer" && position != "manager")
                {
                    if (i < 5)
                    {
                        income += hours[i] * 10;
                    }

                    else
                    {
                        income += hours[i] * 10 * 2;
                    }                   
                }

                if (hours[i] > 8)
                {
                    income += (hours[i] - 8) * 5;
                }               
            }
            if (hoursSum > 50)
            {
                income = income + ((income * (20))/100);
            }
            Console.WriteLine($"Saxeli: {name}");
            Console.WriteLine($"Gvari: {surname}");
            Console.WriteLine($"Asaki: {age}");
            Console.WriteLine($"Pozicia: {position}");
            Console.WriteLine($"shemosavali aris: {income}");

            shemosavali = income;
        }

    }
}
