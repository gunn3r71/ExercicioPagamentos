using Payments.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<Employee>();
            char outSourced;
            string name;
            int hours;
            decimal valuePerHour, additionalCharge;
            try
            {
                Console.Write("Enter the number of employees: ");
                int numberEmployees = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberEmployees; i++)
                {
                    Console.WriteLine($"Employee #{i} data:");
                    Console.Write("OutSourced (y/n)? ");
                    outSourced = char.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Hours: ");
                    hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    valuePerHour = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    if (outSourced == 'Y' || outSourced == 'y')
                    {
                        Console.Write("Additional charge: ");
                        additionalCharge = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        employeeList.Add(new OutSourcedEmployee(name,hours,valuePerHour,additionalCharge));
                    }
                    else
                    {
                        employeeList.Add(new Employee(name, hours, valuePerHour));
                    }
                }

                Console.WriteLine("\nPayments:");

                foreach (var employee in employeeList)
                {
                    Console.WriteLine(employee);
                }
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
