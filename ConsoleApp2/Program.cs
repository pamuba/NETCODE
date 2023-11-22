using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Emp {
        public override string ToString()
        {
            return "The Employee Class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Emp ob = new Emp();
            Console.WriteLine(ob.ToString());
            
            Console.ReadLine();

        }
    }
}
