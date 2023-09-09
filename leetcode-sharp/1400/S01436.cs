namespace leetcode_sharp;

// 1436. Destination City
// https://leetcode.com/problems/destination-city/
public class S01436
{
    public string DestCity(IList<IList<string>> paths)
    {
        var from = new HashSet<string>();
        var to = new HashSet<string>();

        foreach (var path in paths)
        {
            from.Add(path[0]);
            to.Add(path[1]);
        }

        return to.FirstOrDefault(city => !from.Contains(city), string.Empty);
    }
}