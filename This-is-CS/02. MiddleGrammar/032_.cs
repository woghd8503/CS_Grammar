using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 의도치 않게 데이터가 오염되는 일이 종종 있는데 C#에는 데이터 오염을 방지할 수 있는 장치가 여럿 있습니다. 접근 한정자, readonly 필드, readonly 구조체, 튜플 등이
// 그 예죠.

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            { Name = "서현",
              Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirthDay : {birth.Name}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }

}

