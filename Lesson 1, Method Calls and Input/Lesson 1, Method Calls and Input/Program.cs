using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Method_Calls_and_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call a Method:")
            CallAMethod();
            NewLine

            Console.ReadKey();
        }

        static void CallAMethod()
        {
            int number = Math.Min(3, 7);
            Console.WriteLine(number);
            string msg = "Yabba dabba doo!";
            Console.WriteLine(msg);
            Console.WriteLine(msg.Substring(0, 1));
        }

    }
}
