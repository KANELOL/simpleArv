using System;

namespace simpleArv
{
    class Program
    {
        static void Main(string[] args)
        {
            var screamer = new ClassThatInheritances(7,3,"Mee awesome", "Me very very awesome");
           var god = new TheOneThatInheritsITAllAndSetsIt();
            Console.WriteLine(screamer.screamMyStats() +" StatScreamed1\n");
            Console.WriteLine(screamer.screamMyStats2() +" StatScreamed2\n");
            Console.WriteLine("The one willl now speak:\n");
            Console.WriteLine(god.screamMyStats2());
        }
    }
}
