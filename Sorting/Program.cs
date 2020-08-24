using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            table.CreateRandomTable();
            int[] cloneTable = new int[table.SortTable.Length];
            cloneTable = (int[])table.SortTable.Clone();
            int[] cloneTable2 = new int[table.SortTable.Length];
            cloneTable2 = (int[])table.SortTable.Clone();


            SelectionSort sort = new SelectionSort();
            sort.Sort(table.SortTable, typeof(SelectionSort));


            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(cloneTable, typeof(InsertionSort));

            HeapSort heapSort = new HeapSort();
            heapSort.Sort(cloneTable2, typeof(HeapSort));

            Console.ReadKey();

        }
    }
}
