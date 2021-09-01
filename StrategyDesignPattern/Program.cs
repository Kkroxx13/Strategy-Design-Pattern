using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new AddOperation());
            Console.WriteLine("10 + 5 ="+context.executeStrategy(10,5));
            Console.WriteLine();

            context = new Context(new SubtractOperation());
            Console.WriteLine("10 - 5 =" + context.executeStrategy(10, 5));
            Console.WriteLine();

            context = new Context(new MultiplyOperation());
            Console.WriteLine("10 * 5 =" + context.executeStrategy(10, 5));
            Console.WriteLine();
        }
    }
}
