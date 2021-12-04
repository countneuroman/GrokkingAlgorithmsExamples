using System;
using System.Collections.Generic;

namespace QuickSort
{
    internal static class Program
    {
        public static void Main()
        {
            List<int> elements = new() {10, 5, 20, 30, 40, 7, 16, 19, 50, 67, 20, 45, 12, 24, 53, 68, 12, 16, 19};
            List<int>result = QuickSort(elements);
            foreach (var i in result)
            {
                Console.Write($"{i}, ");
            }            
        }

        private static List<int> QuickSort(List<int> elements)
        {
            if (elements.Count < 2)
            {
                return elements;
            }
            elements.Sort();

            Random random = new();
            var randIndex = random.Next(elements.Count);
            
            var pivot = elements[randIndex];
            List<int> less = new();
            List<int> greater = new();
                
            for (var i = 1; i < elements.Count; i++)
            {
                if (elements[i] <= pivot)
                {
                    less.Add(elements[i]);
                }
                else
                {
                    greater.Add(elements[i]);
                }
            }

            var result = QuickSort(less);
            result.Add(pivot);
            result.AddRange(QuickSort(greater));
            return result;
        }
    }
}

