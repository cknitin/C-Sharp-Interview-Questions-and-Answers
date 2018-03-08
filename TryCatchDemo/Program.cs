using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    try
                    {
                        int x = 10;
                        int y = 0;
                        int z = x / y;
                    }
                    catch
                    {

                        int x = 10;
                        int y = 0;
                        int z = x / y;

                        Console.WriteLine("c Catch");
                    }
                    finally
                    {
                        Console.WriteLine("c Finally");
                    }
                }
                catch
                {
                    Console.WriteLine("B Catch");
                }
                finally
                {
                    Console.WriteLine("B Finally");
                }
            }
            catch
            {
                Console.WriteLine("A Catch");
            }
            finally
            {
                Console.WriteLine("A Finally");
            }


            Console.ReadLine();
        }
    }
}
