using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    
    class DelegateSingle
    {
        
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }
        
        public void AddNum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public delegate void AddDelegate(int x, int y);
        public delegate string SayDelegate(string str);
        static void Main(string[] args)
        {
            DelegateSingle p = new DelegateSingle();
            AddDelegate a1 = new AddDelegate(p.AddNum);
            a1(100, 200);
            a1(15, 30);
            SayDelegate sd = new SayDelegate(SayHello);
            //string str = DelegateSingle.SayHello("Ankur");
            String str = sd("Raju");
           Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
