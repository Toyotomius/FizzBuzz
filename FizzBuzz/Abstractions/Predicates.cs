using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public abstract class Predicates<T, U>
    {
        public abstract List<Func<T, U>> GetPredicates();
    }
}
