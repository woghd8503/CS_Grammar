using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스 interface가 무엇인지 설명하기 전에, 인터페이스가 어떻게 생겼는지 알아보겠습니다. 인터페이스는 다음과 
// 같이 interface 키워드를 이용해서 선언합니다.

// interface 인터페이스이름
// {
//     반환_형식 메소드이름1 ( 매개변수_목록 );
//     반환_형식 메소드이름2 ( 매개변수_목록 );
//     반환_형식 메소드이름3 ( 매개변수_목록 );
//     // ...
// }

// 인터페이스는 메소드, 이벤트, 인덱서, 프로퍼티만 가질 수 있는데 그나마도 구현부가 없습니다.
// 이상한 점은 그뿐이 아닙니다. 클래스는 접근 제한 한정자로 수식하지 않으면 기본적으로 private으로 선언되지만,
// 인터페이스는 접근 제한 한정자를 사용할 수 없고 모든 것이 public으로 선언됩니다.
namespace Test1
{
    class MainApp
    {


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

