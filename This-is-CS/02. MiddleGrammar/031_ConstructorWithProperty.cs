using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 초기화하고 싶은 프로퍼티만 넣어서 초기화하면 됩니다. 매개변수가 있는 생성자를 작성할 때와 달리 어떤 필드를 생성자 안에서 초기화할지 미리 고민할 필요가 없습니다.
// 

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

