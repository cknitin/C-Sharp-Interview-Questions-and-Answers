using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class ExtensionMethodDemo
    {
        public static string GetFirstLettlerUpper(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value[0].ToString().ToUpper();
            }
            else
                return string.Empty;
        }

        public static string GetMultipleOfTen(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value[0].ToString().ToUpper();
            }
            else
                return string.Empty;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nitin".GetFirstLettlerUpper());

            Console.ReadLine();
        }
    }
}
