﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        // public int Capacity => list.Capacity; // 읽기 전용
        public int Capacity // 속성
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        // public string this[int index] => list[index]; // 읽기 전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eney");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
        }
    }
}
