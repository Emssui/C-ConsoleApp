using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Test");

            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long hugNumber = 90000000000L;
            Console.WriteLine(hugNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            
            Console.ReadLine();

        }
    }
}
