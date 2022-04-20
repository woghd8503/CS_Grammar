﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머마다 중첩 클래스를 이용하는 이유가 다양하지만, 기본적으로는 다음 두 가지 때문입니다. 
// 1. 클래스 외부에 공개하고 싶지 않은 형식을 만들고자 할 때
// 2. 현재 클래스의 일부분처럼 표현할 수 있는 클래스를 만들고자 할 때


namespace _002.MiddleGrammar
{
   class Configuraion
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach (ItemValue iv in listConfig)
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

            public void SetValue(Configuraion config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i] == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break; 45
                    }
                }
               
            }
        }
    }
}
