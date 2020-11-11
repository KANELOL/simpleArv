using System;
using System.Collections.Generic;
using System.Text;

namespace simpleArv
{
    class ClassThatInheritances : BaseClass
    {
        private string extraMessage;
        public ClassThatInheritances(int stronk, int smork, string message, string extraMessage) : base(stronk, smork, message)
        {
            this.extraMessage = extraMessage;
        }

        public string screamMyStats2()
        {
            string returnStr = this.screamMyStats() + extraMessage;
            return returnStr;
        }
    }
}
