using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    public class Part2
    {
        List<int> objects = new List<int>();

        public Part2()
        {
            Console.WriteLine("===LINQ===");
            Console.WriteLine("= part 2 =");
            Console.WriteLine("= Querys =");
            Console.WriteLine("==========");

            objects.Add(45);
            objects.Add(84);
            objects.Add(10);
            objects.Add(16);
            objects.Add(30);

            Console.WriteLine("");
            Console.WriteLine("== Sort ==");
            sort();
            Console.WriteLine("");
            Console.WriteLine("== create Sort then add one ==");
            sortAddSort();
        }

        private void sortAddSort()
        {
            var result = from num in objects orderby num select num;

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            objects.Add(90);
            Console.WriteLine("== Added 90 ==");
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        private void sort()
        {
            var result = from num in objects orderby num select num;

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
