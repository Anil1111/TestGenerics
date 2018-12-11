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

            Console.WriteLine($"{firstvalue} {secValue}");

            var floatPair = new Pair<float>(1.2f, 3.4f);
            Console.WriteLine($"{floatPair.First} {floatPair.Second}");

            var noGenericPair = new Pair(5, 10);
            Console.WriteLine($"{noGenericPair.First} {noGenericPair.Second}");
        }
    }
}
