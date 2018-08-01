using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    #region Problem

    interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        int WaistSize { get; set; }
    }

    class Jeans : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WaistSize { get; set; }
    }

    class BaseBallCap : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WaistSize { get; set; } // <-- extra property which never going to use in Baseball cap class
        public int HatSize { get; set; } // <-- Required property need to add
    }

    #endregion


    // Solution

    interface IProduct2
    {
        int Id { get; set; }
        string Name { get; set; }
    }

    interface IPants
    {
        int WaistSize { get; set; }
    }

    interface ICap
    {
        int HatSize { get; set; }
    }

    class Jeans2 : IProduct2, IPants
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WaistSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class BaseballCap : IProduct2, ICap
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HatSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
