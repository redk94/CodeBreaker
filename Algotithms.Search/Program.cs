using System;

namespace Algorithms.Search
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeOfArray = 10;
            int[] numbers;

            //numbers = GetRandomNumberList(sizeOfArray);
            //numbers = new int[] { 5, 3, 7, 6, 2, 1, 4 };
            numbers = new int[] { -6, -3, 1, 2, 4, 5, 7 };

            DisplayList("--Init: ", numbers);

            try
            {
                for (int i = 0; i <= numbers.Length - 1; i++)
                {
                    ISearchable Searcher = GetSearcher(eSearch.Binary);
                    int target = i;
                    if (target % 3 == 0)
                        target = -target;

                    int idx = Searcher.Search(numbers, target);

                    if (Searcher.Found)
                        Console.WriteLine(string.Concat("Result:  ", target, " found from ", idx));
                    else
                        Console.WriteLine(string.Concat("Result:  ", target, " not exist. "));
                }

                for (int i= numbers.Length - 1; i >= 0; i--)
                {
                    ISearchable Searcher = GetSearcher(eSearch.Binary);
                    int target = i;
                    if (target % 3 == 0)
                        target = -target;
                    int idx = Searcher.Search(numbers, target);

                    if (Searcher.Found)
                        Console.WriteLine(string.Concat("Result:  ", target, " found from ", idx));
                    else
                        Console.WriteLine(string.Concat("Result:  ", target, " not exist. "));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        static void DisplayList(string prefix, int[] list)
        {
            Console.WriteLine(string.Concat(prefix, " ", string.Join(",", list)));
        }

        enum eSearch { Sequential, Binary }

        static ISearchable GetSearcher(eSearch searcherType)
        {
            switch (searcherType)
            {
                case eSearch.Sequential :
                    return new Sequential();
                case eSearch.Binary :
                    return new Binary();
                default:
                    throw new NotImplementedException();
            }
        }

        static int[] GetRandomNumberList(int sizeOfArray, int seedMax = 20)
        {
            int[] numbers = new int[sizeOfArray];
            Random generator = new Random();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = generator.Next(1, seedMax);
            }

            return numbers;
        }
    }
}
