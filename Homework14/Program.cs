namespace Homework14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Reverse elements:");
            numbers.PrintReverse();

            Console.WriteLine("\nFirst element:");
            Console.WriteLine(numbers.GetFirstElement());

            Console.WriteLine("\nLast element:");
            Console.WriteLine(numbers.GetLastElement());

            Console.WriteLine("\nContains element 30?");
            Console.WriteLine(numbers.ContainsElement(30));

            Console.WriteLine("\nNumber of elements:");
            Console.WriteLine(numbers.CountElements());

            Console.WriteLine("\nIndex of element 40:");
            Console.WriteLine(numbers.FindIndex(40));

            Console.WriteLine("\nIndex of element 100:");
            Console.WriteLine(numbers.FindIndex(100));
        }
    }
}
