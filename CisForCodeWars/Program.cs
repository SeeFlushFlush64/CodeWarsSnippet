using System;
namespace CisForCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Generate(1));
            
        }
        public static string Generate(int size)
        {
            char letterC = 'C';
            int multiplier = 5;
            int numOfLines = size * multiplier;
            // for (int i = 0; i < (int) (numOfLines * 0.2); i++)
            // {
            //     Console.WriteLine(new string(letterC, numOfLines));
            // }
            // for (int i = (int) (numOfLines * 0.2); i < numOfLines * 0.8; i++)
            // {
            //     Console.WriteLine(letterC);
            // }
            // for (int i = (int) (numOfLines * 0.8); i < numOfLines; i++)
            // {
            //     Console.WriteLine(new string(letterC, numOfLines));
            // }
            string cLetter = "";
            for (int i = 0; i < (int) (numOfLines * 0.2); i++)
            {
                cLetter += new string(letterC, numOfLines) + '\n';
            }
            for (int i = (int) (numOfLines * 0.2); i < numOfLines * 0.8; i++)
            {
                cLetter += letterC;
                cLetter += '\n';
            }
            for (int i = (int) (numOfLines * 0.8); i < numOfLines; i++)
            {
                cLetter += new string(letterC, numOfLines);
            }
            return cLetter;
        }
    }
}