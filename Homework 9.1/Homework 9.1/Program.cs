using System;

namespace Homework_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hours = new int[7];
            int hour = 0;

            var company = new Company();
            Console.Write("Chaweret Qveyana: ");
            var country = Console.ReadLine();
            
            var employee = new Eployee();
            Console.Write("Saxeli: ");
            employee.name = Console.ReadLine();

            Console.Write("Gvari: ");
            employee.surname = Console.ReadLine();

            Console.Write("Asaki: ");
            employee.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Shemoiyvanet Pozicia: ");
            employee.position = Console.ReadLine();


            for (int i = 0; i < hours.Length; i++)
            {
                Console.Write($"Shemoiyvanet {i + 1} Dgis Namushevari Saatebi: ");
                hour = Convert.ToInt32(Console.ReadLine());
                hours[i] = hour;
            }
            employee.InCome(employee.position, hours);
            company.Budget(country, employee.shemosavali);

            
            
        }
    }
}
