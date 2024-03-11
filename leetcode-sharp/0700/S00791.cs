namespace leetcode_sharp;

// 791. Custom Sort String
// https://leetcode.com/problems/custom-sort-string/description
public class S00791
{
    public string CustomSortString(string order, string s)
    {
        var dict = new Dictionary<char, int>();

        for (var i = 0; i < order.Length; i++)
        {
            dict.Add(order[i], i); 
        }

        return new string(s.ToCharArray().OrderBy(c => dict.GetValueOrDefault(c, int.MaxValue)).ToArray());
    }
}