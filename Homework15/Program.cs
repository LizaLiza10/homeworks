namespace Homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
               
                new Player("Name1", 100, true),
                new Player("Name2", 200, false),
                new Player("Name3", 300, true),
                new Player("Name4", 300, true),
                new Player("Name5", 300, false),
                new Player("Player6", 300, true),
                new Player("Player7", 350, false),
                new Player("Player8", 500, true),
                new Player("Player9", 450, false),
                new Player("Player10", 600, true)
            };



            players.First(p => p.Score > 200);
            players.FirstOrDefault(p => p.Score > 200);


            players.Count(x => x.Score > 300);

            players.Any(x => x.Score > 300);





            var sortedPayers = players.OrderByDescending(p => p.Score).ThenBy(p => p.Name).ThenByDescending(p => p.IsActive);

            foreach (var item in sortedPayers)
            {
                Console.WriteLine(item);
            }


            var activePlayers = players.Where(p => p.IsActive);

            foreach (var item in activePlayers)
            {
                Console.WriteLine(item);
            }




            var maxScorePlayer = players.OrderByDescending(p => p.Score).FirstOrDefault();

         

            var maxScore = players.Max(p => p.Score);
          

            var maxscorewithmaxBy = players.MaxBy(p => p.Score);
            

            Console.WriteLine(maxScore);
            Console.WriteLine(maxscorewithmaxBy);
           

            var minScoreplayer = players.Where(x => x.IsActive).Min(x => x.Score);
            Console.WriteLine(minScoreplayer);





            var playernames = players.Select(x => new { x.Name, x.Score });



            foreach (var item in playernames.Skip(5).Take(5))
            {
                Console.WriteLine(item);
            }
        }
    }
}
