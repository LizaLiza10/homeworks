namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Where:");
            foreach (var item in numbers.Where(x => x > 5))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFirstOrDefault:");
            Console.WriteLine(numbers.FirstOrDefault(x => x > 5));

            Console.WriteLine("\nAny:");
            Console.WriteLine(numbers.Any(x => x > 8));

            Console.WriteLine("\nAll:");
            Console.WriteLine(numbers.All(x => x > 0));

            Console.WriteLine("\nCount:");
            Console.WriteLine(numbers.Count());

            Console.WriteLine("\nCount with condition:");
            Console.WriteLine(numbers.Count(x => x > 5));
        }
    }
    }
}
 