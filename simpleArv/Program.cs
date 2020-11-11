using System;

namespace simpleArv
{
    class Program
    {
        static void Main(string[] args)
        {
            var screamer = new ClassThatInheritances(7,3,"Mee awesome", "Me very very awesome");
            Console.WriteLine(screamer.screamMyStats() +" StatScreamed1\n");
            Console.WriteLine(screamer.screamMyStats2() +" StatScreamed2\n");
        }
    }
}
