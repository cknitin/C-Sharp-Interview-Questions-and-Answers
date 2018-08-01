using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IQueryableDemo
{
    // The IQueryable class is used to develop LINQ query providers. This feature is used to develop the .NET Framework itself.
    class Demo : IQueryable
    {
        public Expression Expression => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 5, 10, 20 };
            // We can convert an int array to IQueryable.
            // ... And then we can pass it to Queryable and methods like Average.
            double result = Queryable.Average(values.AsQueryable());
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
