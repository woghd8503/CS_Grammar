using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분할 클래스 Partial Class란, 여러 번에 나눠서 구현하는 클래스를 말합니다. 분할 클래스는 그 자체로 특별한 기능을 하는 것은 아니며 클래스의 구현이 길어질 경우
// 여러 파일에 나눠서 구현할 수 있게 함으로써 소스 코드 관리의 편의를 제공하는 데 그 의미가 있습니다.

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
            
        private class ItemValue // Configuration 클래스 안에 선언된 중첩 클래스 입니다. private으로 선언했기 때문에 Configuration 클래스 밖에서 보이지 않습니다.
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++) // 중첩 클래스는 상위 클래스의 멤버에 자유롭게 접근할 수 있습니다.
                {
                    if (config.listConfigp[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break; 45
                    }

                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            { return item; }
            public string GetValue()
            { return value;  }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            configuration config = new configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655.324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
        }
    }
}
