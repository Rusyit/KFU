using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog02092023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("МирТрудМай");
            Console.WriteLine("Мир");
            Console.WriteLine("  Труд");
            Console.WriteLine("     Май");
            int num1 = 0, num2 = 0;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 + "," + num1);
        }
        
    }
    
}