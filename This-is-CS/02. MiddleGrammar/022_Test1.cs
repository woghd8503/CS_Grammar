using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test1
{
    class MainApp
    {
        // Q1. 클래스와 객체, 인스턴스는 서로 어떤 점이 다른가요?

        // A1. 클래스는 OOP Object-Oriented Programming의 핵심이다. 왜냐하면 OOP의 핵심은 사람이 실제세계에서 사물을 바라보는 것처럼, 
        // 직관적인 프로그래밍이 가능하도록 하는 것인데, 클래스가 이 사물의 도면에 해당하기 때문이다. 예를 들어 어떤 사물이 존재한다면,
        // 그 사물에 대한 설계도난 도면 또한 동시에 존재할 확률이 높다. 이러한 개채(=인스턴스, 사물)의 도면역할을 한다. 책에서는 클래스를 
        // 개체를 만들기 위한 청사진으로 정의하였다.

        // 즉, 개체(인스턴스)는 프로그램 내에 실존하는 것이며, 클래스는 이를 실체화하기 위한 도면이다.



        // Q2. 다음 코드에서 오류를 찾고, 오류의 원인을 설명하세요.

        // Q3. this키워드와 base 키워드에 대해 설명하세요.

        // Q4. 구조체에 대한 다음 설명 중 틀린 것을 모두 찾으세요.
        //    1. struct 키워드를 이용하여 선언한다.
        //    2. 복사할 때 얕은 목사가 이루어진다.
        //    3. 참조 형식이다.
        //    4. 메소드를 가질 수 있다.


    }

    // Q5. 다음 코드를 컴파일 및 실행이 가능하도록 수정하세요.
    struct ACSetting
    {
        public double currentInCelsius; // 현재 온도 ( 도시)
        public double target;           // 희망 온도

        public readonly double GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32; // 화씨 ( F) 계산 결과를 target에 저장
            return target; // target 반환
        }
    }

}

