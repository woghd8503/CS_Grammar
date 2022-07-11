using System;

namespace Test
{
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