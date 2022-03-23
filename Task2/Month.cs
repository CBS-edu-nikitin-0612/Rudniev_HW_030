using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Month
    {
        public readonly string Name { get; }
        public readonly int AmountDays { get; }

        public Month(string name, int amountDays)
        {
            this.Name = name;
            this.AmountDays = amountDays;
        }

        public override string ToString()
            => $"name {Name}, days {AmountDays}";
    }
}
