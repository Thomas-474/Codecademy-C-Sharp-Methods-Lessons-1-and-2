using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Method_Calls_and_Input
{
    class Program
    {
        static void NL()
        {
            Console.WriteLine("");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Call a Method:");
            CallAMethod();
            NL();

            Console.WriteLine("Capture Output:");
            CaptureOutput();
            NL();

            Console.WriteLine("Define a Method:");
            //();
            NL();

            Console.WriteLine("Define Parameters:");
            //();
            NL();

            Console.WriteLine("A Note on Parameters:");
            //();
            NL();

            Console.WriteLine("Optional Parameters:");
            //();
            NL();

            Console.WriteLine("Named Arguments:");
            //();
            NL();

            Console.WriteLine("Method Overloading:");
            //();
            NL();

            Console.WriteLine("Review:");
            //();
            NL();

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

        static void CaptureOutput()
        {
            string designer = "Anders Hejlsberg";
            int indexOfSpace = designer.IndexOf(" ");
            string secondName = designer.Substring(indexOfSpace);
            Console.WriteLine(secondName);
        }

        static void DefineAMethod()
        {

        }

        static void DefineParameters()
        {

        }

        static void ANoteOnParameters()
        {

        }

        static void OptionalParameters()
        {

        }

        static void NamedArguments()
        {

        }

        static void MethodOverloading()
        {

        }

        static void Review()
        {

        }

    }
}
