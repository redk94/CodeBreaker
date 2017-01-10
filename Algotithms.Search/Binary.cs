using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    //looks easy but implementaion is tricky.
    class Binary : ISearchable
    {
        public int Location { get; private set; }

        public bool Found { get; private set; }

        public Binary()
        {
            Location = -1;
            Found = false;
        }        

        public int Search(int[] list, int target)
        {
            Location = BinarySearchWithWhile(list, target);
            Console.WriteLine();

            //---------------------------------------------

            BinarySearchWithFor(list, 0, list.Length -1, target);

            return Location;
        }

        void BinarySearchWithFor(int[] list, int left, int right, int target)
        {
            if (Found)
                return;

            int middle = (left + right) / 2;
            //Console.WriteLine("compar from indx" + low + "-" + high + " with middle is "+ middle + " value is " + list[middle]);

            int result = Compare(list, middle, target);

            if (left == right || result == 0)
                return;

            if(result == 1 && middle > 0)
            {
                BinarySearchWithFor(list, left, middle - 1, target);
            }
            else if( result == -1 && middle +1 <= list.Length-1)
            {
                BinarySearchWithFor(list, middle + 1, right, target);
            }           
        }

        int Compare(int[] list, int idx, int target)
        {
            if (list[idx] == target)
            {
                Found = true;
                Location = idx;
                return 0;
            }
            else if (list[idx] < target)
                return -1;
            else
                return 1;
        }

        int BinarySearchWithWhile(int[] list, int target)
        {
            int left = 0;
            int right = list.Length  - 1;

            do
            {
                int mid = (left + right) / 2;

                if (target == list[mid])
                {
                    Found = true;
                    return mid;
                }

                if (target > list[mid]) //middle is smller than target
                    left = mid + 1; // set min to right side index
                else
                    right = mid - 1; //middle is smller than target, so set mas to left side index

            }
            while (left <= right);

            return -1;
        }
    }
}