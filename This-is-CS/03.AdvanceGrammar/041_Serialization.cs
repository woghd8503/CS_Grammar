using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            using (Stream ws = new FileStream("a.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                NameCard nc = new NameCard();
                nc.Name = "박상현";
                nc.Phone = "010-123-4567";
                nc.Age = 33;
                serializer.Serialize(ws, nc);
            }

            using Stream rs = new FileStream("a.bat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);

            Console.WriteLine($"Name: {nc2.Name}");
            Console.WriteLine($"Name: {nc2.Phone}");
            Console.WriteLine($"Name: {nc2.Age}");
        }
    }
}
