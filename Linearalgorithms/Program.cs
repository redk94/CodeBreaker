using System;

namespace Algorithms.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeOfArray = 10;
            int[] numbers;

            //numbers = GetRandomNumberList(sizeOfArray);
            numbers = new int[] { 5, 3, 7, 6, 2, 1, 4};

            DisplayList("--Init: ", numbers);

            ISortable sorter = GetSorter(eSorter.Quick);
            numbers = sorter.Sort(numbers, eOrderBy.Asc);

            DisplayList("Sorted: ", numbers);
        }

        static void DisplayList(string prefix, int[] list)
        {
            Console.WriteLine(string.Concat(prefix, " ",  string.Join(",", list)));
        }

        enum eSorter { Selection, Merge, Quick, Insertion, Bubble }

        static ISortable GetSorter(eSorter sorterType)
        {
            switch (sorterType)
            {
                case eSorter.Merge:
                    return new MergeSort();
                case eSorter.Quick:
                    return new QuickSort();
                default:
                    throw new NotImplementedException();

            }
        }

        static int[] GetRandomNumberList(int sizeOfArray, int seedMax = 20)
        {
            int[] numbers = new int[sizeOfArray];
            Random generator = new Random();
            for(int i=0; i < numbers.Length-1; i++ )
            {
                numbers[i] = generator.Next(1, seedMax);
            }

            return numbers;
        }
    }
}
