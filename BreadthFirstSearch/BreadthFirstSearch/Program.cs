
namespace BreadthFirstSearch;

internal static class Program
{
    public static void Main()
    {
        
        Dictionary<string, string[]> friendsGraph = new()
        {
            { "You", new[] { "Alice", "Bob", "Claire" } },
            { "Bob", new[] { "Anuj", "Peggy" } },
            { "Alice", new []{"Peggy"} },
            { "Claire", new []{"Thom", "Jonnys"} },
            { "Anuj", Array.Empty<string>() },
            { "Peggy", Array.Empty<string>() },
            { "Thom", Array.Empty<string>() },
            { "Jonnys", Array.Empty<string>() }
        };
        string[] myFriends = friendsGraph["You"];
        var searched = new HashSet<string>();

        Queue<string> queue = new(myFriends);

        while (queue.Count > 0)
        {
            string name = queue.Dequeue();
            if (searched.Contains(name))
                continue;
            else
            {
                searched.Add(name);
                if (name[^1] == 'm')
                {
                    Console.WriteLine($"{name} is seller mango!");
                    
                    break;
                }
            }

            var friends = friendsGraph[name].ToList();
            friends.ForEach(x => queue.Enqueue(x));
        }
    }
}