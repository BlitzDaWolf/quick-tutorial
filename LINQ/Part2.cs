using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    public class Part2
    {
        List<int> objects = new List<int>();

        /*
            new Tuple<int, string>(26, "banaan"),
            new Tuple<int, string>(11, "rijbaan"),
            new Tuple<int, string>(11, "lamp"),
            new Tuple<int, string>(39, "lamp"),
            new Tuple<int, string>(11, "boom"),
            new Tuple<int, string>(35, "apple")
         */

        public Part2()
        {
            objects.Add(45);
            objects.Add(84);
            objects.Add(10);
            objects.Add(16);
            objects.Add(30);

            sort();
            Console.WriteLine("");
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
            Console.WriteLine("");
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
