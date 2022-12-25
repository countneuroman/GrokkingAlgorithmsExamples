namespace QuickSort
{
    internal static class Program
    {
        public static void Main()
        {
            int[] elements = new[] {10, 5, 12, 32, 65, 7};
            QuickSort(elements, 0, elements.Length - 1);
            foreach (int i in elements)
            {
                Console.Write($"{i}, ");
            }            
        }

        private static void QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex < maxIndex)
            {
                int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

                QuickSort(array, minIndex, pivotIndex - 1);

                QuickSort(array, pivotIndex + 1, maxIndex);
            }

        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivotValue = array[maxIndex];
            
            int pivotIntendedPosition = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < pivotValue)
                {
                    pivotIntendedPosition++;
                    Swap(array, pivotIntendedPosition, i);
                }
            }
            Swap(array, pivotIntendedPosition + 1, maxIndex);

            return pivotIntendedPosition + 1;
        }

        private static void Swap(int[] array, int leftIndex, int rightIndex)
        {
            int temp = array[leftIndex];

            array[leftIndex] = array[rightIndex];

            array[rightIndex] = temp;
        }
    }
}

