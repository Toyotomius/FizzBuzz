using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            var predicates = new FizzBuzzPredicates();

            fizzBuzz.Execute(1, 100, predicates);
        }
    }
}
