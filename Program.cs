using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Bai2
{
    internal class Program
    {
        public static List<AmountException> listError = new List<AmountException>(); 
        public static void Main(string[] cmd)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Input your Infomation :");
                Console.WriteLine("Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Salary :");
                int salary = int.Parse(Console.ReadLine());
                Faculity faculity = new Faculity(name, salary);
                int sal = faculity.getBonus(salary);
                if (salary < 60000)
                {
                    throw new AmountException("You get the salary < 60000", name);
                }
                else if(sal > 10000)
                {
                    throw new AmountException("You get the Bonus < 10000", name);
                }
                else
                {
                    Console.WriteLine("==============\n-----Info-----\nName : " + faculity.Name);
                    Console.WriteLine("Faculity : " + faculity.Salary + "\nBonus : " + sal);
                }
                Console.WriteLine("Out ??\n1. yes");
                int chon = int.Parse(Console.ReadLine());
                if(chon == 1)
                {
                    Console.WriteLine("You chose out :)))), see you !");
                    flag = false;
                }
            }
        }
    }
}
