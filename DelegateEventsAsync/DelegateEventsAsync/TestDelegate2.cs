using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    class TestDelegate2<G1 , G2>
    {
        public void Display(G1 s1, G2 s2)
        {
            Console.WriteLine("The Value of s1 and s2: {0},{1}", s1, s2);
        }

    }
    public delegate void delegatename(object  s1, object s2);
    class GenericClass2
    {
        static void Main(string[] args)
        {
            TestDelegate2<string, int> obj1 = new TestDelegate2<string, int>();
          //  delegatename<object,object> m1 = new delegatename<object,object>(obj1);
            TestDelegate2<int, float> obj2 = new TestDelegate2<int, float>();
            TestDelegate2<double, float> obj3 = new TestDelegate2<double, float>();
            obj1.Display("krishna", 1);
            obj2.Display(2, 2.2f);
            obj3.Display(2.5, 3.5f);
            Console.Read();
        }
    }
}
