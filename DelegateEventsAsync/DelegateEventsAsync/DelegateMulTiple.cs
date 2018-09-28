using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAsync
{
    class DelegateMulTiple
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of Rectangle:-" + (width * height));
        }
        public void GetParameter(double width, double height)
        {
            Console.WriteLine("Parameter of Rectangle:-" +( 2 * (width + height)));
        }

        public delegate void Rectangle(double width, double height);
        static void Main(string[] args)
        {
            DelegateMulTiple dm = new DelegateMulTiple();
            Rectangle r = new Rectangle(dm.GetArea);
            r += dm.GetParameter;
            r(2.5, 3.5);
            Console.ReadLine();
        }
    }
}
