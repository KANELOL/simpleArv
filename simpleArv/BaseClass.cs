using System;
using System.Collections.Generic;
using System.Text;

namespace simpleArv
{
    class BaseClass
    {
        //Noen enkle variabler!
        public int stronk { get; }
        public int smork { get; }
        public string message { get; }
        // Skriv ctor for constructor!
        //Constructor her.
        public BaseClass(int stronk, int smork, string message)
        {
            this.stronk = stronk;
            this.smork = smork;
            this.message = message;
        }
        //En funksjon
        public string screamMyStats()
        {
            string returnStr =
                $"I am {stronk} stronkers! I am {smork} smorts! And my message to the world is: {message}";
           return returnStr;
        }
    }
}
