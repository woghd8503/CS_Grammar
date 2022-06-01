using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 프로퍼티 선언 문법에서 get {...}과 set {...}을 일컬어 접근자 accessor라고 합니다. get 접근자는 필드로부터 값을 읽어오고 set 접근자는 필드에 값을 할당합니다.
// set 접근자 안에 있는 value 키워드를 주목하기 바랍니다. 이 친구는 누구도 선언한 적이 없지만, C# 컴파일러는 set 접근자의 암묵적 매개변수로 간주하므로 전혀 문제
// 삼지 않습니다.

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }

}


