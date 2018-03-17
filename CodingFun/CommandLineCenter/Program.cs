using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms4th;

namespace CommandLineCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock World!");
            var algo4th = CheckCheck.Sum(8, 8);
            Console.WriteLine($"{algo4th}");
            Console.ReadKey();
        }
    }
}
