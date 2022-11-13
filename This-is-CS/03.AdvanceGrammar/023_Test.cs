using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    // 다음과 같은 배열링 있다고 할 때, Cost는 50이상, MaxSpeed는 150 이상인 레코드만
    // 조회하는 LINQ를 작성하세요.

    class Car1
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }


    //...
    //Car1[] cars =
    //{
    //    new Car(){ Cost=56, MaxSpeed= 120},
    //    new Car(){ Cost=70, MaxSpeed= 150},
    //    new Car(){ Cost=45, MaxSpeed= 180},
    //    new Car(){ Cost=32, MaxSpeed= 200},
    //    new Car(){ Cost=82, MaxSpeed= 280},
    //};

    // var selected = /* Cost가 50 이상, MaxSpeed가 150 이상인 레코드를 조회하는 LINQ */ 
    

    // 다음 코드에서 cars.Where(c => c.Cost < 60).OrderBy(c=>c.Cost)와 동일한 결과를 반환
    // 하는 LINQ를 작성하세요.)

    class Car2
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    // ...
    //Car2[] cars =
    //{
    //    new Car2(){ Cost=56, MaxSpeed=120},
    //    new Car2(){ Cost=70, MaxSpeed=150},
    //    new Car2(){ Cost=45, MaxSpeed=180},
    //    new Car2(){ Cost=32, MaxSpeed=200},
    //    new Car2(){ Cost=82, MaxSpeed=280},
    //};

    // var selected = cars.Where(c => c.Cost < 60).OrderBy(c => c.Cost);
    internal class _023_Test
    {


    }
}
