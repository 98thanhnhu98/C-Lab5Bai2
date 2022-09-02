using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Bai2
{
    internal abstract class Person
    {
       
        public abstract string Name { get; set; }
        public abstract int Salary { get;set; }
        public Person (string name , int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
