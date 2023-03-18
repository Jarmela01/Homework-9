using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9._1
{
    public class Company
    {

        

        public void Budget(string location, double a)
        {
            double budget;

            if (location == "georgia")
            {
                budget = a * 9 / 50;
            }
            else
            {
                budget = a / 20;
            }


            Console.Write($"Qveynis Biujetshi Gadaricxuli Tanxa Aris: {budget}");

        }

        

    }
}
