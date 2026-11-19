namespace Homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CollectionHelper helper = new CollectionHelper();

            helper.AddStudent("Nika", 85);
            helper.AddStudent("Mariam", 92);
            helper.AddStudent("Giorgi", 70);

            helper.ShowAll();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Score: ");
            int score = int.Parse(Console.ReadLine());
            helper.AddStudent(name, score);

            Console.Write("Search name: ");
            helper.SearchStudent(Console.ReadLine());

            Console.Write("Update name: ");
            string updateName = Console.ReadLine();
            Console.Write("New score: ");
            int newScore = int.Parse(Console.ReadLine());
            helper.UpdateScore(updateName, newScore);

            helper.ShowAll();

            Console.WriteLine("Total students: " + helper.students.Count);
        }
    }


}
    

