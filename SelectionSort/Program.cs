using System;
using System.Collections.Generic;

namespace SelectionSort
{
    internal class Program
    {
        public static void Main()
        {
            List<int> nums = new() { 10, 50, 20, 30, 2, 5, 6, 8, 1 };
            List<int> sortNums = SelectionSort(nums);

            for(var i = 0; i < sortNums.Count; i++)
            {
                Console.WriteLine($"{sortNums[i]}");
            }

            Console.ReadLine();
        }

        private static List<int> SelectionSort(List<int> nums)
        {
            List<int> sortArr = new();

            for (int i = 0, c = nums.Count; i < c; i++)
            {
                int smallestIndex = FindSmallest(nums);
                sortArr.Add(nums[smallestIndex]);
                nums.RemoveAt(smallestIndex);
            }

            return sortArr;
        }

        private static int FindSmallest(List<int> nums)
        {
            int smallest = nums[0];
            var smallestIndex = 0;
            for(var i = 0; i < nums.Count; i++)
            {
                if(nums[i] < smallest)
                {
                    smallest = nums[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}
