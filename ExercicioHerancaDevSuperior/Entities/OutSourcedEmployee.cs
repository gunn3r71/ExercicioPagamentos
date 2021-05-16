using System;
using System.Collections.Generic;
using System.Text;

namespace Payments.Entities
{
    public class OutSourcedEmployee : Employee
    {
        public decimal AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, decimal valuePerHour, decimal additionalCharge) : base(name,hours,valuePerHour)
        {
            this.AdditionalCharge = additionalCharge;
        }

        public override decimal Payment()
        {
            return base.Payment() + (1.1M * this.AdditionalCharge);
        }
    }
}
