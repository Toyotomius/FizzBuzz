using System;

namespace FizzBuzz
{
    public class FizzBuzz : IFindValuesInRangeWithPredicates<int, string>
    {
        private readonly IWriter _writer;

        public FizzBuzz(IWriter writer)
        {
            _writer = writer;
        }

        public void Execute(int low, int high, Predicates<int, string> predicates)
        {
            if (high < low) { throw new ArgumentException("High value of range is less than low value."); }
            if (predicates is null) { throw new ArgumentNullException(nameof(predicates)); }

            for (var i = low; i <= high; i++)
            {
                var fizzBuzz = "";
                foreach (var predicate in predicates.GetPredicates())
                {
                    if (predicate is null) { continue; }
                    fizzBuzz += predicate(i);
                }

                _writer.Write(!string.IsNullOrWhiteSpace(fizzBuzz) ? fizzBuzz : i.ToString());
            }
        }
    }
}
