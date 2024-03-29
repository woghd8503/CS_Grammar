﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 오버로딩 Overloading이란 "과적하다"라는 뜻을 갖고 있습니다. 과적이란 트럭 따위에 원래의 탑재량을 넘겨 싣는 것을 말하죠.
// 메소드 오버로딩은 하나의 메소드 이름에 여러 개의 구현을 올리는 것을 뜻합니다. 
// int 형식의 매개변수와 반환 형식을 갖고 있는 Plus() 메소드만 있는데, double 형식을 지원하는 버전도 추가해야 한다고 생각해보세요.
// 메소드 오버로딩을 사용하면 Plus()라는 이름을 그대로 사용할 수 있습니다. 하나의 메소드 이름에 여러 개의 구현을 올리는 메소드
// 오버로딩을 사용할 수 있습니다.

// int Plus(int a, int b)
//{
//    return a + b;
//}

// double Plus(double a, double b)
//{
//    return a + b;
//}
// 실행할 메소드의 버전을 찾는 작업이 컴파일 타임에 이루어지므로 성능 저하는 걱정하지 않아도 됩니다.
// 다음은 오버로딩된 Plus() 메소드를 호출하는 예제입니다. 여느 메소드 호출 코드와 다를 바가 없지요?
// int result1 = Plus( 1, 2 ); int Plus( int, int )를 호출합니다.
// double result2 = Plus( 3.1, 2.4 ); double Plus ( double, double )를 호출합니다.


class CodingTest
{

    static void Main()
    {
        int n = int.Parse(sr.ReadLine());
        string s = null;
        string[] fileName = new string[n];
        for (int x = 0; x < n; x++)
            fileName[x] = sr.ReadLine();

        for (int y = 0; y < fileName[0].Length; y++)
        {
            s = null;

            for (int z = 1; z < n; z++)
            {
                if (fileName[0][y] != fileName[z][y])
                {
                    s = "?";
                    break;
                }

            }
            if (s == null)
                s = fileName[0][y].ToString();
            sb.Append(s);
        }

        Console.WriteLine(sb);
    }
}