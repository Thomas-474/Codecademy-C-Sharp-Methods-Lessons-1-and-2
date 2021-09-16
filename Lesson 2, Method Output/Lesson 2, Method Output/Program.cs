using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2__Method_Output
{
    class Program
    {
        static void NL()
        {
            Console.WriteLine("");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("     Return:");
            Return();
            NL();

            Console.WriteLine("     Return Errors:");
            ReturnErrors();
            NL();

            Console.WriteLine("     Out:");
            Out();
            NL();

            Console.WriteLine("     Using Out:");
            UsingOut();
            NL();

            Console.WriteLine("     Out Errors:");
            OutErrors();
            NL();

            Console.WriteLine("     Review:");
            Review();
            NL();

            Console.ReadKey();
        }

        #region Return
            static void Return()
            {
                Console.WriteLine(DecoratePlanet("Jupiter"));
            }

            static string DecoratePlanet(string planet)
            {
                return $"*..*..* Welcome to {planet} *..*..*";
            }
        #endregion

        #region Return Errors
            static void ReturnErrors()
            {
                Console.WriteLine(DecoratePlanet("Mars")); 
                Console.WriteLine("Is Pluto really a dwarf...?");
                Console.WriteLine(IsPlutoADwarf());
                Console.WriteLine("Then how many planets are there in the galaxy...?");
                Console.WriteLine(CountThePlanets());
            }

            static string DecoratePlanet2(string planet)
            {
                return $"*..*..* Welcome to {planet} *..*..*";
            }
            
            static bool IsPlutoADwarf()
            {
                bool answer = true;
                return answer;
            }
            
            static string CountThePlanets()
            {
                return "8 planets, usually";
            }
        #endregion

        #region Out
            static void Out()
            {
                string ageAsString = "102";      
                string nameAsString = "Granny";
                
                int ageAsInt;
                bool outcome;
                
                outcome = Int32.TryParse(ageAsString, out ageAsInt);
                
                Console.WriteLine(outcome);
                Console.WriteLine(ageAsInt);
                
                int nameAsInt;
                bool outcome2;
                
                outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
                
                Console.WriteLine(outcome2);
                Console.WriteLine(nameAsInt);
            }
        #endregion

        #region Using Out
            static void UsingOut()
            {
                Console.WriteLine(Whisper("This is the Phrase", out bool marker));
            }

            static string Whisper(string phrase, out bool wasWhisperCalled)
            {
                wasWhisperCalled = true;
                return phrase.ToLower();
            }
        #endregion

        #region Out Errors
            static void OutErrors()
            {
                string statement = "GARRRR";
                bool marker;
			    string murmur = Whisper2(statement, out marker);
                Console.WriteLine(murmur);
            }

            static string Whisper2(string phrase, out bool wasWhisperCalled)
            {
                wasWhisperCalled = true;
                return phrase.ToLower();
            }
        #endregion

        #region Review
            static void Review()
            {
                // Define variables
                string destination = "Neptune";
                string galaxyString = "8";
                int galaxyInt;
                string welcomeMessage;
                bool outcome;
                outcome = Int32.TryParse(galaxyString, out galaxyInt);
                
                // Call DecoratePlanet() and TryParse() here
                welcomeMessage = DecoratePlanet3(destination);

                // Print results
                Console.WriteLine(welcomeMessage);
                Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");
            }

            // Define a method that returns a string
  	        static string DecoratePlanet3(string planet)
            {
                return $"*..*..* Welcome to {planet} *..*..*";
            }
            
            // Define a method with out
            static string Whisper3(string phrase, out bool wasWhisperCalled)
            {
                wasWhisperCalled = true;
                return phrase.ToLower();
            }
        #endregion

    }
}
