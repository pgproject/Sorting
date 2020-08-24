using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class AbstractSort
    {
        public void Sort(int [] sort, Type type)
        {
            Stopwatch time = Stopwatch.StartNew();
            Sorting(sort);
            _printResult(time, type);
        }
        protected abstract void Sorting(int [] sort);
        private void _printResult(Stopwatch time, Type type)
        {
            var stop = Stopwatch.StartNew();
            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }*/
            var stopWatch = time.ElapsedMilliseconds - stop.ElapsedMilliseconds;
            var second = stopWatch / 1000;
            var decaSecond = (stopWatch - second * 1000) / 100;
            var centySeceond = (stopWatch - (second * 1000) - (decaSecond * 100)) / 10;
            var miliSecend = stopWatch - (second * 1000) - (decaSecond * 100) - (centySeceond * 10);
            Console.WriteLine("Czas wykonania sortowania dla "+type.Name+" w milisekundach:" + (time.ElapsedMilliseconds - stop.ElapsedMilliseconds));
            Console.WriteLine("Czas wykonania sortowania:" + second.ToString() + " sekund," + decaSecond.ToString() + " decysuknd," + centySeceond.ToString() + " centysekund," + miliSecend + " milisekund");
            Console.WriteLine();
            time.Stop();

        }

    }
}
