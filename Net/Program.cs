using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int f = 0;
            try
            {
                var s = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Fik");
                throw;
            }


            Console.ReadKey();
        }
    }
}
