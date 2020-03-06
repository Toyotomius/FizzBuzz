using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzPredicates : Predicates<int,string>
    {
        public override List<Func<int, string>> GetPredicates()
        {
            return new List<Func<int, string>>
            {
               (int x) => (x % 3 == 0) ? "Fizz" : "",
               (int x) => (x % 5 == 0) ? "Buzz" : ""
            };
        }
    }
}
