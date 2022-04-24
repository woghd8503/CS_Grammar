using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _002.MiddleGrammar
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            min = v2;
        }

        public void ChangeMin(int newMax)
        {
            max = newMax;      // 
        }
    }
   


}
