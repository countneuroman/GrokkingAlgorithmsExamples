namespace BinarySearch;

internal static class Program
{
    public static void Main()
    {
        var elements = new List<int> {1,5,8,10,15,20};
        Console.WriteLine("Введите число:");
        var guess = Convert.ToInt32(Console.ReadLine());

        int? index = FindElementIndex(elements, guess);
        
        if(index is not null)
            Console.WriteLine($"Индекс числа {guess} = {index}");
        else
            Console.WriteLine($"Число {guess} не найдено в исходном списке элементов");
    }

    private static int? FindElementIndex(List<int> elements, int guess)
    {
        var low = 0;
        var high = elements.Count - 1;
        var mid = high / 2;

        while (low <= high)
        {
            if (guess < elements[mid])
            {
                high = mid - 1;
                mid = (low + high) / 2;
            }
            else if (guess > elements[mid])
            {
                low = mid + 1;
                mid = (low + high) / 2;
            }
            else
            {
                return mid;
            }
        }
        return null;
    }
}