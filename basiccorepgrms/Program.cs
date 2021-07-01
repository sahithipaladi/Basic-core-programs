using System;

namespace basiccorepgrms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the options");
            Console.WriteLine("1.Leap Year");
            Console.WriteLine("2. Prime Factors of Number");
            Console.WriteLine("3. Alphabet Is Vowel Or Consonant");
            Console.WriteLine("4. Largest Among Three Numbers");
            Console.WriteLine("Enter the option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Leap_Year.Readinput();
                    break;
                case 2:
                    Prime_Factors_of_Number.Readinput();
                    break;
                case 3:
                    Alphabet_Is_Vowel_Or_Consonant.Readinput();
                    break;
                case 4:
                    LargestAmongThreeNumbers.Readinput();
                    break;
                default:
                    Console.WriteLine("Invaild options");
                    break;


            }
        }
    }
}
