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
                    catch (Exception ex)
                    {
                        throw;
                    }
                    finally
                    {
                        Console.WriteLine("c Finally");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    Console.WriteLine("B Finally");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("A Finally");
            }


            Console.ReadLine();
        }
    }
}
