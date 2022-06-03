using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 프로퍼티는 데이터의 오염에 대해선 메소드처럼 안전하고, 데이터를 다룰 때는 필드처럼 간결합니다. 하지만, 많은 경우에 중복된 코드를 작성하고 있다는 기분이 들게 합니다.
// 다음 코드의 NameCard클래스를 보세요. Name과 PhoneNumber 프로퍼티는 단순히 name과 phoneNumber 필드를 읽고 쓰기만 합니다. 여기에는 아무 논리도 섞여 있지 않습니다. 
// 마이크로소프트의 C#팀은 이런 경우에 사용해서 코드를 더 단순하게 만드는 자동 구현 프로퍼티 Auto-Implemented Property를 C#3.0부터 도입했습니다.

// 한 가지 더, C# 7.0부터는 다음과 같이 자동 구현 프로퍼티를 선언함과 동시에 초기화를 수행할 수 있습니다. 덕분에 자동 구현 프로퍼티에 초깃값이 필요할 때 생성자에
// 코드를 작성하는 수고를 덜게 되었습니다.


namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
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
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}

// 자동 구현 프로퍼티가 편하다는 건 이제 우리 모두 잘 알게 되었습니다. 그런데 궁금하지 않습니까?

