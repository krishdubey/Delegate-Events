using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    public delegate string Delegatename11(string name);
    class DelegateLambda
    {
        static void Main()
        {
            Delegatename11 dn = (name) =>
            {
                return "Hello " + name + " a very good morning";
            };
            string str = dn("BizrunTime");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
