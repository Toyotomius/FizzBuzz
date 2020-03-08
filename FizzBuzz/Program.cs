namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IWriter consoleWriter = new ConsoleWriter();
            var fizzBuzz = new FizzBuzz(consoleWriter);
            var predicates = new FizzBuzzPredicates();

            fizzBuzz.Execute(1, 100, predicates);
        }
    }
}
