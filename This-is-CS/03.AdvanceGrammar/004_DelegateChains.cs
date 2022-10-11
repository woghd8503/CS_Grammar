using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    delegate void Notify(string message);  // Nofity 대리자 선언
    
    class Notifier  // Notify 대리자의 인스턴스 EventOccured를 가지느 클래스 Notifier 선언
    {
        public Notify EventOccured;
    }

    internal class _004_DelegateChains
    {
    }
}
