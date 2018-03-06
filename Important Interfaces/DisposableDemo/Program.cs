using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableDemo
{
    class Demo : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Call dispose function.");
            GC.SuppressFinalize(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d = null;
            try
            {
                d = new Demo();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                d.Dispose();
            }
            Console.ReadLine();

        }
    }
}
