using System;
using Ex1.Entities;
using System.Globalization;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of empleyees: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");

                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("PAYMANTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}