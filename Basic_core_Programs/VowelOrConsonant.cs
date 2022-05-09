using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class VowelOrConsonant
    {
        public void Vowel_Or_Consonant()
        {
            char ch;
            Console.WriteLine("Please Enter a Alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Alphabet is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Alphabet is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Alphabet is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Alphabet is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Alphabet is Vowel");
                    break;
                default:
                    Console.WriteLine("Alphabet is not a Vowel");
                    break;


            }
        }
    }
}
