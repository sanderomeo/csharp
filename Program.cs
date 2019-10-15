using System;

namespace Codetest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "ROMY";
            int charaterAge = 25;

            Console.WriteLine(" there was 35 a nice guy named ROMY ");
            Console.WriteLine(" there was 35 a nice guy named " + characterName);
            Console.WriteLine(" there was " + charaterAge + " a nice guy");

            characterName = "TOM";
            Console.WriteLine(" there was 35 a nice guy named " + characterName);
            Console.WriteLine(" there was a nice guy named again");

        }
    }
}
