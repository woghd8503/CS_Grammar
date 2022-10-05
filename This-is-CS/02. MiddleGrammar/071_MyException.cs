using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002._MiddleGrammar
{
    internal class _071_MyException : Exception
    {
        public InvalidArgumentEception()
        {
        }

        public InvalidEnumArgumentException(string message)
            :base(message)
        {

        }

    }
}
