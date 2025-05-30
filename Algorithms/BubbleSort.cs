namespace Algorithms
{
    public class BubbleSort : ISort
    {
        const string _a = "B";
        public void Handle(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("BubbleSort completed:");
        }

        public bool IsApplicable(string input)
        {
            return _a.Equals(input, StringComparison.OrdinalIgnoreCase);
        }
    }
}