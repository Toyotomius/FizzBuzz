namespace FizzBuzz
{
    public interface IFindValuesInRangeWithPredicates<T,U>
    {
        void Execute(int low, int high, Predicates<T, U> predicates);
    }
}