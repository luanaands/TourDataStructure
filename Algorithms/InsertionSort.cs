namespace Algorithms
{
    public class InsertionSort : ISort
    {
        const string _a = "I";

        /// <summary>
        /// Sorts an array of integers using the Insertion Sort algorithm.
        /// </summary>
        /// <param name="numbers">The array of integers to be sorted.</param>
        /// <remarks>
        /// The Insertion Sort algorithm builds a sorted array one element at a time by repeatedly taking the next element
        /// and inserting it into the correct position in the already sorted part of the array.
        /// </remarks>
        public void Handle(int[] numbers)
        {
            int initial;
            int index;
            for (int i = 0; i < numbers.Length; i++)
            {
                initial = numbers[i];
                index = i - 1;
                while (index >= 0 && numbers[index] > initial)
                {
                    numbers[index + 1] = numbers[index];
                    index--;
                }
                numbers[index + 1] = initial;
            }
            Console.WriteLine("InsertionSort completed:");
        }
        public bool IsApplicable(string input)
        {
            return _a.Equals(input, StringComparison.OrdinalIgnoreCase);
        }
    }
}