using System;
using System.Collections.Generic;
using PaymentEmployee.Entities;
using System.Globalization;

namespace PaymentEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} data: ");
                Console.Write("Outsorced(y/n) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name,hours,valuePerHours,additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");

            foreach(Employee emp in list)
            {

                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture) );
            }
        }
    }
}
