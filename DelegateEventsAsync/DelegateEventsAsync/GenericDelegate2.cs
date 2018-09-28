using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    class GenericDelegate2
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = obj1(100, 34.5f, 25.35);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) =>
             {
                 Console.WriteLine(x + y + z);
             };
            obj2(100, 35.5f, 65.5);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;

            };
            bool status = obj3("Krishna");
            Console.WriteLine(status);

            Console.ReadLine();
        }
    }
}
