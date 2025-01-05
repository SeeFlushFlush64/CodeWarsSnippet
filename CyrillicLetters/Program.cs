using System;
namespace CyrillicLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = 'a';
            int charValue = myChar;
            Console.WriteLine(charValue.Equals(0x0061));
        }
    }
}