using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 중첩클래스를 사용하는 이유

// 1. 클래스 외부에 공개하고 싶지 않은 형식을 만들고자 할 때
// 2. 현재클래스의 일부분처럼 표현할 수 있는 클래스를 만들고자 할 때

// 다른 클래스의 private 멤버에도 마구 접근할 수 있는 중첩 클래스는 은닉성을 무너뜨리기는 하지만, 보다 유연한 표현력을 프로그래머에게 가져다준다는 장점이 있습니다.

namespace _002.MiddleGrammar
{
   class NestedClass
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }
            
        private class ItemValue
        {
            private string item;
            private string value;
        }
    }
}
