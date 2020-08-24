using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort : AbstractSort
    {
        protected override void Sorting(int[] sort)
        {
            int n = sort.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (sort[j] < sort[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = sort[min_idx];
                sort[min_idx] = sort[i];
                sort[i] = temp;
            }

        }
    }
}
