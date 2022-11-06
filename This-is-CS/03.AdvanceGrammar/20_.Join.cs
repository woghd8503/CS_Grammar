using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Tile { get; set; }
        public string Start { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            Product[] arrProduct =
            {
                new Product(){Title="비트",          Star="정우성"},
                new Product(){Title="CF 다수",       Star="김태희"},
                new Product(){Title="아이리스",       Star="김태희"},
                new Product(){Title="모래시계",       Star="고현정"},
                new Product(){Title="Solo 예찬",       Star="이문세"},
            };

            var listProfile =
                from pofile in arrProfile
                join product in 

        }
    }
}
