using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new() { 10, 50, 20, 30, 2, 5, 6, 8, 1 };
            List<int> sortNums = SelectionSort(nums);

            for(int i = 0; i < sortNums.Count; i++)
            {
                Console.WriteLine($"{sortNums[i]}");
            }

            Console.ReadLine();
        }

        static List<int> SelectionSort(List<int> nums)
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

        static int FindSmallest(List<int> nums)
        {
            int smallest = nums[0];
            int smallest_index = 0;
            for(int i = 0; i < nums.Count; i++)
            {
                if(nums[i] < smallest)
                {
                    smallest = nums[i];
                    smallest_index = i;
                }
            }

            return smallest_index;
        }
    }
}
