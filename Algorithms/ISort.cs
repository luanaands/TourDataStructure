namespace Algorithms
{
    public interface ISort
    {
        bool IsApplicable(string input);
        void Handle(int[] numbers);
    }
}