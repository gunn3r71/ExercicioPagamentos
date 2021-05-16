using System;
using System.Collections.Generic;
using System.Text;

namespace Payments.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public decimal ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, decimal valuePerHour)
        {
            this.Name = name;
            this.Hours = hours;
            this.ValuePerHour = valuePerHour;
        }

        public virtual decimal Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"{this.Name} - $ {this.Payment():F2}";
        }
    }
}
