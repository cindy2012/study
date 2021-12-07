using System;

namespace Try101LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var aggregateOperators = new AggregateOperators();
            //aggregateOperators.CountSyntax();
            //aggregateOperators.CountConditional();
            //aggregateOperators.NestedCount();
            //aggregateOperators.GroupedCount();
            //aggregateOperators.SumProjection();
            //aggregateOperators.SumGrouped();
            //aggregateOperators.MinGrouped();
            //aggregateOperators.SeededAggregate();

            var conversions = new Conversions();
            //conversions.ConvertSelectedItems();

            ElementOperations element = new ElementOperations();
            //element.ElementAtPosition();

            Generators generators = new Generators();
            //generators.RepeatNumber();

            Groupings groupings = new Groupings();
            //groupings.NestedGrouBy();
            //groupings.NestedGroupByCustom();
            JoinOperations joinOperations = new JoinOperations();
            joinOperations.CrossGroupJoin();
            Console.ReadKey();
        }
    }
}
