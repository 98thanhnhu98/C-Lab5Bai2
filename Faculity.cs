using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Bai2
{
    internal class Faculity : Person
    {
        public override string Name { get ;set; }
        public override int Salary { get; set ; }


        public Faculity(string name, int salary) : base(name, salary)
        {
            Name = name;
            Salary = salary;
        }

        public int getBonus(int salary)
        {
            int sal = (int)(0.05 * salary);
            return sal;
        }

    }
}
