using System;

namespace Test
{
    // 다음 코드에서 NameCard 클래스의 GetAge(), SetAge(), GetName(), SetName() 메소드들을 프로퍼티로 변경해 작성하세요.
    class NameCard
    {
        private int age;
        private string name;

        public int GetAge()
        { return age; }

        public void SetAge(int value)
        { age = value; }

        public string GetName()
        { return name; }

        public void SetName(string value)
        { name = value; }
    }

    class MainApp
    {
        public static void Main()
        {
            NameCard MyCard = new NameCard();

            MyCard.SetAge(24);
            MyCard.SetName("상현");

            Console.WriteLine("나이 : {0}", MyCard.GetAge());
            Console.WriteLine("이름 : {0}", MyCard.GetName());
        }
    }

}