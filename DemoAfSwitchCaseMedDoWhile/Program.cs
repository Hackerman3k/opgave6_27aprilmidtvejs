using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAfSwitchCaseMedDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var date = DateTime.Now;
            var output = $"\nKlokken er {date:t} den {date:d} og maskinen virker";
            Console.WriteLine(output);
            Console.WriteLine("---Velkommen til Maskinen---\n");

            double[] deciTal = new double[10];
            for (int i = 0; i < deciTal.Length; i++)
            {
               
                Console.WriteLine("Indtast dit decimal tal");
                deciTal[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tal nummer: {0} er indtastet", 1+i);
               
            }
            Console.Clear();
            Console.WriteLine("Du har indtastet 10 tal");

            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Her er dine 10 tal");
            Array.Sort(deciTal); //sortering af array - kan vendes om med Array.Reverse() hvor () er array værdi


            foreach (double skriv in deciTal)
            {
                Console.WriteLine(skriv);
                Console.WriteLine(".......");

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte");
            Console.ResetColor();
            Console.ReadKey(); //venter på at brugeren får læst det de skal før den går videre.
            Console.Clear();

            Console.WriteLine("-----------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Største tal: {0}", deciTal.Max()); //printer max værdi fra array.
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Mindste tal: {0}", deciTal.Min()); //tager mindste værdi for et array og printer det til konsollen.
            Console.ResetColor();
            Console.WriteLine("Her er alle tal ganget med 2");

            Console.WriteLine("{0,10}  {1,10}\n", "Ganget", "Uganget");

            foreach (double lokaltal in deciTal)
            {
            
                var stringformat = String.Format("{0,10:#.###}: {1,10:#.###}", lokaltal*2, lokaltal);
                Console.WriteLine(stringformat);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------");
                Console.ResetColor();

            }
            Console.ReadKey();

                    //Console.WriteLine("{0:#.###}", lokaltal*2 );








        }















    }
}
