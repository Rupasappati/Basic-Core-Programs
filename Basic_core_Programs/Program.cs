// See https://aka.ms/new-console-template for more information


namespace Basic_core_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {

            Flip_Coin myobj = new Flip_Coin();
            myobj.Heads_Tails();
            LeapYear obj = new LeapYear();
            obj.Leap_year();
            PowerOfTwo inst = new PowerOfTwo();
            inst.Power_Of_Two();
            HormonicNum hormonicNum = new HormonicNum();
            hormonicNum.Hormonic_Num();
            Factors factors = new Factors();
            factors.FactorsOfNum();
            SwapNum swapNum = new SwapNum();
            swapNum.SwapTwoNum();
            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.Even_Or_Odd();
            VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
            vowelOrConsonant.Vowel_Or_Consonant();
            LargestNum largestNum = new LargestNum();
            largestNum.Largest_Num();
        }
    }
}
