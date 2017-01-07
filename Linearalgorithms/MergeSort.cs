using System;
using System.Collections.Generic;
using System.Linq;

namespace Linearalgorithms
{
    public class MergeSort : ISortable
    {
        public int[] Sort(int[] listToSort, eOrderBy orderBy)
        {
            return DivideList(listToSort);
        }

        /// <summary>
        /// split list into 2 list and combine them
        /// </summary>
        private int[] DivideList(int[] list)
        {
            if (list.Length == 1)
                return list;

            int splitPos = ((list.Length-1)/2) + 1;

            var temp1 = new int[splitPos];
            Array.Copy(list, 0, temp1, 0, splitPos);
            var leftList = DivideList(temp1);

            var temp2 = new int[list.Length - splitPos];
            Array.Copy(list, splitPos, temp2, 0, list.Length - splitPos);
            var rightList = DivideList(temp2);

            return CombineList(leftList, rightList);
        }

        // compare 2 list one by one, add larger one to newlist and delelt till one of lists get empty
        // append left list then append right list
        private int[] CombineList(int[] arr1, int[] arr2)
        {
            List<int> leftList = arr1.ToList();
            List<int> rightList = arr2.ToList();

            List<int> newList = new List<int>();

            // find smller numbers and add it to new list
            while (leftList.Count > 0 && rightList.Count > 0)
            {
                if (leftList[0] < rightList[0])
                {
                    newList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else
                {
                    newList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Add the rest from leftList
            while (leftList.Count > 0)
            {
                newList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }

            // Add the rest from rightList
            while (rightList.Count > 0)
            {
                newList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }


            return newList.ToArray();
        }


        /// for loop version
        public void Sort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left)/2;

                Sort(numbers, left, mid);
                Sort(numbers, mid+1, right);

                Merge(numbers, left, mid+1, right);
            }

        }

        private void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int endOfList, num, currentPositon;

            endOfList = (mid-1);
            currentPositon = left;
            num = (right - left + 1);

            while (left <= endOfList && mid <= right)
            {
                //temp[pos++] = (numbers[left] <= numbers[mid]) ? numbers[left++] : numbers[mid++];

                if (numbers[left] <= numbers[mid])
                    temp[currentPositon++] = numbers[left++];
                else
                    temp[currentPositon++] = numbers[mid++];
            }

            while (left <= endOfList)
            {
                temp[currentPositon++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[currentPositon++] = numbers[mid++];
            }

            for (int i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
