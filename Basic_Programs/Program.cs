
using System;

namespace Basic_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC_CORE_PROGRAMS");
            Console.WriteLine("1.EVEN/ODD");
            Console.WriteLine("2.VOWEL/CONSONANT");
            Console.WriteLine("3.SWAPPING OF 2 NUMBERS");
            Console.WriteLine("4.LARGEST OF 3 NUMBERS");
            int select=Convert.ToInt32(Console.ReadLine());
          
           
                switch(select)
                {
                    case 1:
                        EvenorOdd.EvenOdd evenOdd = new EvenorOdd.EvenOdd();
                        evenOdd.EVENODD();
                        break;
                        case 2:
                            Alphabet.Alphabet alpha=new Alphabet.Alphabet();
                        alpha.Alph();
                        break;
                    case 3:
                      Swap.Swap myobj= new Swap.Swap();
                        myobj.Swap2_numbers();
                        break;
                case 4:
                    Largest.Large_Number myObj1 = new Largest.Large_Number();
                    myObj1.large();
                    break;
                    default:
                        Console.WriteLine("ENTER ANOTHER PROBLEM NO:");
                        break;

                }
                
            }
           
        }
    }
