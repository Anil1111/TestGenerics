using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var pair = new Pair<int>(1,2);
            var firstvalue = pair.First;
            var secValue = pair.Second;

            Console.WriteLine(pair);

            var floatPair = new Pair<float>(1.2f, 3.4f);
            Console.WriteLine(floatPair);

            var noGenericPair = new Pair(5, 10);
            Console.WriteLine(noGenericPair);

            var pairOfPairs = new Pair<Pair<int>>(new Pair<int>(1, 2), new Pair<int>(3, 4));
            Console.WriteLine(pairOfPairs);

            var intAndString = new Pair<int, string>(23, "whatever");
            Console.WriteLine(intAndString);

            var intAndInt = new Pair<int>(90, 109);
            Console.WriteLine(intAndInt);
        }
    }
}
