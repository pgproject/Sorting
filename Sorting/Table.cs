using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    public class Table
    {
        public int[] SortTable;
        int maxValue = 50000;
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        public void CreateRandomTable()
        {
            SortTable = new int[maxValue];
            for (int i = 0; i < SortTable.Length; i++)
            {
                SortTable[i] = rnd.Next(maxValue);
            }
        }
        public void CreateAscendingTable()
        {
            SortTable = new int[maxValue];
            int value = 0;
            for (int i = 0; i < SortTable.Length; i++)
            {
                SortTable[i] = value;
                value++;
            }
        }
        public void CreateDecreasingTable()
        {
            int value = 70000;
            SortTable = new int[value];
            for (int i = 0; i < SortTable.Length; i++)
            {
                SortTable[i] = value;
                value--;
            }
        }
        public void CreateConstantTable()
        {
            int value = 70000;
            SortTable = new int[value];
            for (int i = 0; i < SortTable.Length; i++)
            {
                SortTable[i] = value;
            }
        }
        public void CreateTrigonometricTable()
        {
            int addValue = 1;

            int length = 70000;

            int val = 10000;            

            int minValue = 10000;
            int maxValue = 20000;
            SortTable = new int[length];
            for (int i = 0; i < SortTable.Length; i++)
            {
                SortTable[i] = val;
                val += addValue;
                if (val == maxValue)
                    addValue = -1;
                else if (val == minValue)
                    addValue = 1;
            }
        }
    }
}
