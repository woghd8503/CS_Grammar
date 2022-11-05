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
            new Profile() {name="이문세", Height=178},
            new Profile() {name="하하", Height=171},
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { Groupkey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine();
                
                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($">>> {profile.name}, {profile.Height}");
                }
            }
        }
    }
}
