using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace LINQ
{
    public class Part1
    {
        int[] arr = {26, 48, 39, 11, 35};
        Tuple<int, string>[] tuples = {
            new Tuple<int, string>(26, "banaan"),
            new Tuple<int, string>(11, "rijbaan"),
            new Tuple<int, string>(11, "lamp"),
            new Tuple<int, string>(39, "lamp"),
            new Tuple<int, string>(11, "boom"),
            new Tuple<int, string>(35, "apple")
        };

        public Part1()
        {
            sortFunction();
            Console.WriteLine("");
            sortTuple();
            Console.WriteLine("");
            sortTupleThenBy();
            Console.WriteLine("");
            findItem("lamp");
            Console.WriteLine("");
            findItemOne("lamp");
            Console.WriteLine("");
            loop();
            Console.WriteLine("");
            loopShoort();
        }

        private void loopShoort()
        {
            arr.ToList().ForEach(print);
        }

        void print(int o)
        {
            Console.WriteLine(o);
        }

        private void loop()
        {
            arr.ToList().ForEach(value =>
            {
                Console.WriteLine(value);
            });
        }

        private void findItemOne(string v)
        {
            var result = tuples.FirstOrDefault(value => value.Item2 == v);

            Console.WriteLine($"Age: {result.Item1}; Name: {result.Item2}; Hash: {result.GetHashCode()}");
        }

        private void findItem(string v)
        {
            var result = tuples.Where(value => value.Item2 == v);

            foreach (var item in result)
            {
                Console.WriteLine($"Age: {item.Item1}; Name: {item.Item2}; Hash: {item.GetHashCode()}");
            }
        }

        private void sortTupleThenBy()
        {
            var result = tuples.OrderBy(value => value.Item1).ThenBy(value => value.Item2).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Age: {item.Item1}; Name: {item.Item2}; Hash: {item.GetHashCode()}");
            }
        }

        private void sortTuple()
        {
            var result = tuples.OrderBy(value => value.Item1).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Age: {item.Item1}; Name: {item.Item2}; Hash: {item.GetHashCode()}");
            }
        }

        private void sortFunction()
        {
            var result = arr.OrderBy(number => number).ToList();

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

        }

        
    }
}
