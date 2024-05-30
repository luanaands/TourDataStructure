namespace Algorithms
{
    public static class SelectionSort
    {
        public static int[] Handle(int[] numbers)
        {
            int copy, minor;
            for (int i = 0; i < numbers.Length; i++)
            {
                minor = SearchMinor(numbers, i);
                copy = numbers[minor];
                numbers[minor] = numbers[i];
                numbers[i] = copy;
            }
            return numbers;
        }
        static int SearchMinor(int[] numbers, int j)
        {
            int minor = numbers[j];
            int index = j;
            for (int i = j; i < numbers.Length; i++)
            {
                if (numbers[i] < minor)
                {
                    minor = numbers[i];
                    index = i;
                }
            }
            return index;
        }
    }
}