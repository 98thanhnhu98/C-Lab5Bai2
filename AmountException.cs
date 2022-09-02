using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Bai2
{
    internal class AmountException : Exception
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public AmountException(string error, string name)
        {
            Name = name;
            Console.WriteLine("The user name : " + Name + " get error : " + error);
        }
    }
}
