using System;

namespace Reversecase
{
    class Program
    {
        public static string ReverseCase(string reverse)
        {
            string output = "";
            int i = 0;
            while (i < reverse.Length)
            {
                if (char.IsLower(reverse[i]))
                {
                    output += char.ToUpper(reverse[i]);
                }
                else if (char.IsUpper(reverse[i]))
                {
                    output += char.ToLower(reverse[i]);
                }
                else if (reverse[i] == ' ')
                {
                    output += reverse[i];
                }
                i++;
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("Happy Birthday")); // "hAPPY bIRTHDAY"
            Console.WriteLine(ReverseCase("MANY THANKS")); // "many thanks"
            Console.WriteLine(ReverseCase("sPoNtAnEoUs")); // "SpOnTaNeOuS"
        }
    }
}