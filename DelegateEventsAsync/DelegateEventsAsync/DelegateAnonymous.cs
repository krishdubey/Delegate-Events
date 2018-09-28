using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    public delegate string Delegatename(string name);
    class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            Delegatename dn = name =>
            {
                return "Hello " + name + " a very good morning";
            };
            string str = dn("Krishna");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
