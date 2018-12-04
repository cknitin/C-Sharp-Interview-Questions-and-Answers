using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> data = new List<int>();
            data.Add(1996);
            data.Add(1997);
            data.Add(1998);
            data.Add(1999);
            data.Add(2000);
            data.Add(2001);
            data.Add(2002);
            data.Add(2003);
            data.Add(2004);
            data.Add(2005);

            Get1990To2000((IEnumerator<int>)data.GetEnumerator());

            Console.ReadLine();

        }

        public static void Get1990To2000(IEnumerator<int> o)
        {

            while (o.MoveNext())
            {
                if (Convert.ToInt32(o.Current.ToString()) > 2000)
                {
                    Get2001AndAbove(o);
                }
                else
                    Console.WriteLine("Get1990To2000: " + o.Current.ToString());
            }
        }


        public static void Get2001AndAbove(IEnumerator<int> o)
        {

            Console.WriteLine("Get2001AndAbove: " + o.Current.ToString());
        }

    }
}
