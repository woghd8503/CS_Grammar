using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class Test1
    {
        static void Main(string[] args)
        {
            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();
            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();

            int answer = Int32.Parse(width) * Int32.Parse(height);

            WriteLine("사각형의 넓이는 : " + answer);
        }
    }
}

// 다음 코드에서 잘못된 부분을 찾고, 그 이유을 설명하세요
// int a = 7.3;         answer: int형은 정수로 소수점을 가진 실수를 대입하지 못함.
// float b = 3.14;      answer: float 실수 자료형에 대입할 실수는 뒤에 f를 표기해줘야함.
// double c = a * b;    answer: a와 b를 올바르게 수정한다면 문제 없음.
// char d = "abc";      answer: char는 한개의 문자를 대입해야 함, 또한 쌍 따옴표가 아닌 따옴표를 사용.
// string e = '한';     answer: 반대로 string은 문자의 열을 대입, 따옴표가 아닌 쌍 따옴표를 사용.


