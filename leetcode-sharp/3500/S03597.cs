namespace leetcode_sharp;

// 3597. Partition String
// https://leetcode.com/problems/partition-string
public class S03597
{
    public IList<string> PartitionString(string s)
    {
        var result = new List<string>();
        var temp = "";
        var seen = new HashSet<string>();

        foreach (var ch in s)
        {
            temp += ch;

            if (seen.Add(temp))
            {
                result.Add(temp);
                temp = "";
            }
        }
        
        return result;
    }
}