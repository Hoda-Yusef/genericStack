using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            specialStack<double> s = new specialStack<double>(10);
            int i;
            Random rnd = new Random();

            for(i=0;i<10;i++)
            {
                s.push(rnd.NextDouble() * 10);
            }

            Console.WriteLine(s.ToString());
        }
    }
}
