using System;

namespace FizzBuzz
{
    public class FizzBuzz : IFindValuesInRangeWithPredicates<int,string>
    {
        public void Execute(int low, int high, Predicates<int, string> predicates)
        {
            for (var i = low; i <= high; i++)
            {
                var fizzBuzz = "";
                foreach (var itm in predicates.GetPredicates())
                {
                    fizzBuzz += itm(i);
                }

                Console.WriteLine(!string.IsNullOrEmpty(fizzBuzz) ? fizzBuzz : i.ToString());
            }
        }
    }
}
