using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 50000;
            int[] sort = new int[maxValue];
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            
            for (int i = 0; i < sort.Length; i++)
            {
                sort[i] = rnd.Next(maxValue);
                Console.WriteLine(sort[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
