
using System;

namespace Basic_Core
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("BASIC_CORE_PROGRAMS");
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.EVEN/ODD");
                Console.WriteLine("2.VOWEL/CONSONANT");
                Console.WriteLine("3.SWAPPING OF 2 NUMBERS");
                Console.WriteLine("4.LARGEST OF 3 NUMBERS");
                Console.WriteLine("5.QUOTIENT & REMAINDER");
                Console.WriteLine("6.LEAP YEAR OR NOT");
                Console.WriteLine("7.PERCENTAGE OF COIN FLIP");
                Console.WriteLine("8.Nth HARMONIC NUMBER");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        EvenorOdd.EvenOdd evenOdd = new EvenorOdd.EvenOdd();
                        evenOdd.EVENODD();
                        break;
                    case 2:
                        Alphabet.Alphabet alpha = new Alphabet.Alphabet();
                        alpha.Alph();
                        break;
                    case 3:
                        Swap.Swap myobj = new Swap.Swap();
                        myobj.Swap2_numbers();
                        break;
                    case 4:
                        Largest.Large_Number myObj1 = new Largest.Large_Number();
                        myObj1.large();
                        break;
                    case 5:
                        Compute.Quotient_Remainder div = new Compute.Quotient_Remainder();
                        div.program();
                        break;
                    case 6:
                        LeapYear.LeapYear year = new LeapYear.LeapYear();
                        year.years();
                        break;
                    case 7:
                        CoinFlip.CoinFlip flip = new CoinFlip.CoinFlip();
                        flip.coin();
                        break;
                    case 8:
                        Harmonic.Harmonic number = new Harmonic.Harmonic();
                        number.Harmonic_Number();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT NO:");
                        break;
                }
            }
               
            }
            }
           
        }
    
