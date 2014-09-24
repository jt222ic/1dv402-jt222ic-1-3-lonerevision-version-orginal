using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv405_jt222ic_1._3_lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {


            int income = 0;                             ///// Variabler för löner


            do
            {

                Console.Clear();
                income = ReadInt("Ange antalet löner: ");                   ///// värden som skrivs för antalet löner
                //// ReadInt läser in värden från metoder
                Console.WriteLine();

                if (income <= 1)                                                  ///// om income är mindre eller lika med 1
                {                                                                 //// så kommer förvarningen
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("För liten mängd löner.");
                    Console.ResetColor();
                }
                /////// Annars fortsätter den med att köra igenom

                else
                {
                    ProcessSalaries(income);                              ///// köra inkomsten
                }


                Console.BackgroundColor = ConsoleColor.DarkGreen;                                  /// avslutad text  
                Console.WriteLine("Tryck valfri tangent för att göra en omberäkning - Esc avslutar");
                Console.ResetColor();

                ///
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);        ///// avslutande delen om man vill forsätta 
            /// eller trycka escape av att avsluta.
        }

        static void ProcessSalaries(int antal)
        {
                                            //// void//värden kan ta emot men kan inte skickas ut till andra metoder.
            int[] payment = new int[antal];                                ///boxer tal 

            //// uträkning för antal löner som skrivs
            for (int i = 0; i < antal; ++i)
            {
                ////  inmatning av värden :)
                payment[i] = ReadInt("Ange lön nr: " + (1 + i) + ": ");    //// skrivs ut löne siffror efter varandra
            }


            int[] presentation = (int[])payment.Clone();      //// Klonar ange löner till nedersta raden ///




            Console.WriteLine("-------------------------------------------------");

            Array.Sort(payment);                     ///behandling av array

            int diffrence = payment.Max() - payment.Min();                    ///// beräkning av löneskillnaden



            if (payment.Length % 2 == 0)
            {
                int Middlenumber1 = payment.Length / 2;
                int Middlenumber2 = payment.Length / 2 - 1;                   ///// uträkning för jämna tal för median
                int median = (payment[Middlenumber1] + payment[Middlenumber2]) / 2;   //// resultaten
                Console.WriteLine("Medianen:       {0:c0}", median);
            }

            else if (payment.Length % 2 == 1)                            ///////// uträkning för Ojämna tal för median
            {                                                             ///// resultaten
                int UnEvenMedian = payment.Length / 2;
                Console.WriteLine("Medianen:       {0:c0}", payment[UnEvenMedian]);



                Console.WriteLine("Medellön:            {0:c0}", payment.Average());          //// resultaten Medel
                Console.WriteLine("Lönespridning:       {0:c0}", diffrence);                   //// resultaten löne
                Console.WriteLine("--------------------------------------------------");
            }


            for (int i = 0; i < payment.Length; ++i)      ///// klonade arrayen här för att sätta ut i placerings
            {
                if (i % 3 == 0)                          
                {
                    Console.WriteLine();
                }

                Console.Write("   {0,5} ", presentation[i]);      //// klonade delen  då tidigare har jag använt klon formen.
            }                                                    //// översta raden

            Console.WriteLine();
        }
        static int ReadInt(string text)                        ////// skriven text looop in da looop
        {                                             ///// returneras   med return quantanty, allstå text

            int quantity = 0;

            do
            {
                string input;                              //// första text inskriven
                Console.Write(text);
                input = Console.ReadLine();
                try
                {

                    quantity = int.Parse(input);                         ///// måste breaka annars oändlig
                    break;                                          /// stannas vid text om man inte har break

                }
                catch
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! {0} kan inte tolkas som ett heltal", input);  //// inmatning av bokstäver
                    Console.ResetColor();
                    Console.WriteLine();

                }

            } while (true);                                          //// fortsätter looopen

            return quantity;                               /////// returnerar quantaity början från static int
        }

    }
}

    

    

       



        
