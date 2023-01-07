namespace DijkstraAlgorithm;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> weighetedGraph = new()
        {
            { "start", new Dictionary<string, int>() { {"a", 6}, {"b", 2} } },
            { "a", new Dictionary<string, int>() { {"finish", 1} } },
            { "b", new Dictionary<string, int>() { {"a", 3}, {"finish", 5} } },
            { "finish", new Dictionary<string, int>() }
        };

        Dictionary<string, int> costs = new()
        {
            {"a", 6},
            {"b", 2},
            {"finish", int.MaxValue} //MaxValue represents infinity.
        };

        Dictionary<string, string> parents = new()
        {
            {"a", "start"},
            {"b", "start"},
            {"finish", string.Empty}
        };

        HashSet<string> processed = new();

        GetShortAndLowCostPath(weighetedGraph, costs, parents, processed);
    }

    private static void GetShortAndLowCostPath(Dictionary<string, Dictionary<string, int>> weighetedGraph,
        Dictionary<string, int> costs, Dictionary<string, string> parents, HashSet<string> processed)
    {
        string lowCostNode = FindLowestCostNode(costs, processed);
        while (lowCostNode != string.Empty)
        {
            int cost = costs[lowCostNode];
            Dictionary<string, int> neighbors = weighetedGraph[lowCostNode];
            foreach (var neighbor in neighbors)
            {
                int newCost = cost + neighbor.Value;
                if (costs[neighbor.Key] > newCost)
                {
                    costs[neighbor.Key] = newCost;
                    parents[neighbor.Key] = lowCostNode;
                }
            }

            processed.Add(lowCostNode);
            lowCostNode = FindLowestCostNode(costs, processed);
        }
    }

    private static string FindLowestCostNode(Dictionary<string, int> costs, HashSet<string> processed)
    {
        var filteredNodes = costs.Where(x => x.Value >= 0 & !processed.Contains(x.Key)).ToArray();
        if (filteredNodes.Length <= 0)
            return "";
        return filteredNodes.MinBy(x=>x.Value).Key;
    }
}