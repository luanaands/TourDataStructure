namespace Algorithms
{
    public static class InsertionSort
    {
       public  static int[] Handle(int[] numbers){
            int initial;
            int index;
            for (int i = 0; i < numbers.Length; i++)
            {
                initial = numbers[i];
                index = i-1;
                while (index >= 0 && numbers[index] > initial){
                    numbers[index + 1] = numbers[index];
                    index--;
                }
                numbers[index+1] = initial;
            }
            return numbers;
        }
    }
}