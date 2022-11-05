using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class Profile
    {
        public string name { get; set; }
        public int Height { get; set; }
    }
    internal class _019_GroupBy
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
            new Profile() {name="정우성", Height=186},
            new Profile() {name="김태희", Height=158},
            }
        }
    }
}
