﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    // 다음과 같은 배열링 있다고 할 때, Cost는 50이상, MaxSpeed는 150 이상인 레코드만
    // 조회하는 LINQ를 작성하세요.

    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }


    //...
    //Car[] cars =
    //{
    //    new Car(){ Cost=56, MaxSpeed= 120},
    //    new Car(){ Cost=70, MaxSpeed= 150},
    //    new Car(){ Cost=45, MaxSpeed= 180},
    //    new Car(){ Cost=32, MaxSpeed= 200},
    //    new Car(){ Cost=82, MaxSpeed= 280},
    //};

    // var selected = /* Cost가 50 이상, MaxSpeed가 150 이상인 레코드를 조회하는 LINQ */ 

    internal class _023_Test
    {


    }
}
