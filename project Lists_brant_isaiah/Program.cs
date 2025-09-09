namespace project_Lists_brant_isaiah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo",
                "Borderlands 3",
                "Fifa 22",
                "Mincraft",
            };


            string[] otherGames = new string[]
            {
                "Tiny Tina",
                "Farcry 3"
            };

            foreach (string game in games) ;
            {
                Console.WriteLine(games);
            }

            Console.WriteLine($"\nGames in list: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"\nGames in list: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHEAF IS IN THE HOUSE!!");
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;

            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            Console.WriteLine("\nAll gamws in the list:");
                foreach (string game in games) 
            {
                Console.WriteLine(games);
            }

            games.Sort();

            Console.WriteLine("\nSorted game list:");
            foreach (string game in games)
            {
                Console.WriteLine(games);
            }

            string[] newList = new string [games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}