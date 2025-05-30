namespace Algorithms
{
    public class SelectionSort : ISort
    {
        const string _a = "S";
        public void Handle(int[] numbers)
        {
            int copy, minor;
            for (int i = 0; i < numbers.Length; i++)
            {
                minor = SearchMinor(numbers, i);
                copy = numbers[minor];
                numbers[minor] = numbers[i];
                numbers[i] = copy;
            }
            Console.WriteLine("SelectionSort completed:");
        }

        public bool IsApplicable(string input)
        {
            return _a.Equals(input, StringComparison.OrdinalIgnoreCase);
        }

        private int SearchMinor(int[] numbers, int j)
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