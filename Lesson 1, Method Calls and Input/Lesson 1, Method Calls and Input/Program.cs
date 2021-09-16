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
            Console.WriteLine("     Call a Method:");
            CallAMethod();
            NL();

            Console.WriteLine("     Capture Output:");
            CaptureOutput();
            NL();

            Console.WriteLine("     Define a Method:");
            DefineAMethod();
            NL();

            Console.WriteLine("     Define Parameters:");
            DefineParameters();
            NL();

            Console.WriteLine("     Optional Parameters:");
            OptionalParameters();
            NL();

            Console.WriteLine("     Named Arguments:");
            NamedArguments();
            NL();

            Console.WriteLine("     Method Overloading:");
            MethodOverloading();
            NL();

            Console.WriteLine("     Review:");
            Review();
            NL();

            Console.ReadKey();
        }

        #region Call A Method
            static void CallAMethod()
            {
                int number = Math.Min(3, 7);
                Console.WriteLine(number);
                string msg = "Yabba dabba doo!";
                Console.WriteLine(msg);
                Console.WriteLine(msg.Substring(0, 1));
            }
        #endregion

        #region Capture Output
            static void CaptureOutput()
            {
                string designer = "Anders Hejlsberg";
                int indexOfSpace = designer.IndexOf(" ");
                string secondName = designer.Substring(indexOfSpace);
                Console.WriteLine(secondName);
            }
        #endregion

        #region Define A Method
            static void DefineAMethod()
            {
                VisitPlanets();
            }

            static void VisitPlanets()
            {
                Console.WriteLine("You visited many new planets...");
            }
        #endregion

        #region Define Parameters
            static void DefineParameters()
            {
                VisitPlanets(3);
                VisitPlanets(4);
                VisitPlanets(5);
            }

            static void VisitPlanets(int numberOfPlanets)
            {
                Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            }
        #endregion

        #region Optional Parameters
            static void OptionalParameters()
            {
                VisitPlanets2(3);
                VisitPlanets2(4);
                VisitPlanets2(5);
                VisitPlanets2();
            }

            static void VisitPlanets2(int numberOfPlanets = 0)
            {
                Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            }
        #endregion

        #region Named Arguments
            static void NamedArguments()
            {
                VisitPlanets3(numberOfPlanets: 2, name: "Thomas");
            }

            static void VisitPlanets3(
            string adjective = "brave",
            string name = "Cosmonaut", 
            int numberOfPlanets = 0,
            double gForce = 4.2)
            {
                Console.WriteLine($"Welcome back, {adjective} {name}.");
                Console.WriteLine($"You visited {numberOfPlanets} new planets...");
                Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
            }
        #endregion

        #region Method Overloading
            static void MethodOverloading()
            {
                NamePets("Laika", "Albert");
                NamePets("Mango", "Puddy", "Bucket");
                NamePets();
            }

            static void NamePets(string pet1, string pet2)
            {
                Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
            }  

            static void NamePets(string pet1, string pet2, string pet3)
            {
                Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
            }  

            static void NamePets()
            {
                Console.WriteLine("Aw, you have no spacefaring pets :(");
            }
        #endregion

        #region Review
            static void Review()
            {
                NamePets2("Laika", "Albert");
                VisitPlanets4(numberOfPlanets: 8);
            }

            static void NamePets2()
            {
                Console.WriteLine("Aw, you have no spacefaring pets :(");
            }

            static void NamePets2(string pet1, string pet2)
            {
                Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
            }  

            static void NamePets2(string pet1, string pet2, string pet3)
            {
                Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
            }  

            static void VisitPlanets4(
            string adjective = "brave",
            string name = "Cosmonaut", 
            int numberOfPlanets = 0,
            double gForce = 4.2)
            {
                Console.WriteLine($"Welcome back, {adjective} {name}.");
                Console.WriteLine($"You visited {numberOfPlanets} new planets...");
                Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
            }
        #endregion

    }
}
