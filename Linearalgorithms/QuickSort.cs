using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    /*
    initial call to QuickSort(list, 0, list.length-1)
    QuickSort(list, low, high)
    1. if(low >= high) return;
    2. get PartitionIdx
    3. quickSort(list, low, partIdx)
    4. quickSort(list, partIdx+1, high1)

    Partition(list, low, high)
    1. set pivot value from list[high]
    2. set PfS(place for swap) with low
    3. loop list from low to high-1 
    4. if(list[j] <= pivot) swap(list[i], swap[j]) and pfs++
    5. after looping ends, swap(number[i], swap[high]) -- pivot value
    6. return current swapplace for partitionIdx
    */

    class QuickSort : ISortable
    {
        public int[] Sort(int[] numbers, eOrderBy orderBy)
        {
            RunQuickSort(numbers, 0, numbers.Length - 1, orderBy);
            return numbers;
        }

        private void RunQuickSort(int[] numbers, int low, int high, eOrderBy orderBy)
        {

            if (low >= high)
            {
                //Console.WriteLine(string.Concat("stop", "low: ", low, " - high: ", high, ", ", string.Join(",", numbers)));
                return;
            }

            //Console.WriteLine(string.Concat("low: ", low, " - high: ", high, ", ", string.Join(",", numbers)));
            int partIdx = Partition(numbers, low, high, orderBy);

            //Console.WriteLine(string.Concat("low: ", low, " - high: ", partIdx-1, ", ", string.Join(",", numbers)));
            RunQuickSort(numbers, low, partIdx - 1, orderBy);
            //Console.WriteLine(string.Concat("low: ", partIdx-1, " - high: ", high, ", ", string.Join(",", numbers)));
            RunQuickSort(numbers, partIdx + 1, high, orderBy);
        }

        private int Partition(int[] numbers, int low, int high, eOrderBy order)
        {
            int pivot = numbers[high];
            int PoS = low; //place for swaping

            for (int i = low; i <= high - 1; i++)
            {
                if ((order == eOrderBy.Asc && numbers[i] <= pivot) || (order == eOrderBy.Desc && numbers[i] >= pivot))
                {
                    Swap(numbers, PoS, i);
                    PoS++;
                }
            }

            Swap(numbers, PoS, high);
            return PoS;
        }

        private void Swap(int[] numbers, int left, int right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
        }

        private int PartitionTemp(int[] numbers, int low, int high, eOrderBy order)
        {

            int pivot = numbers[high];
            int PoS = low; //place for swaping

            for (int i = low; i <= high - 1; i++)
            {
                if (order == eOrderBy.Asc)
                {
                    if (numbers[i] <= pivot)
                    {
                        Swap(numbers, PoS, i);
                        PoS++;
                    }
                }
                else
                {
                    if (numbers[i] >= pivot)
                    {
                        Swap(numbers, PoS, i);
                        PoS++;
                    }
                }
            }

            Swap(numbers, PoS, high);
            return PoS;
        }
    }
}