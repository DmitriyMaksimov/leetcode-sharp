namespace UnitTests;

// 3443. Maximum Manhattan Distance After K Changes
// https://leetcode.com/problems/maximum-manhattan-distance-after-k-changes
public class S03443
{
    public int MaxDistance(string s, int k)
    {
        var dictionary = new Dictionary<char, int>
        {
            { 'N', 0 },
            { 'S', 0 },
            { 'E', 0 },
            { 'W', 0 }
        };
        
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            dictionary[s[i]]++;
            var temp = Math.Min(i + 1, Math.Abs(dictionary['N'] - dictionary['S']) + Math.Abs(dictionary['E'] - dictionary['W']) + 2 * k);
            result = Math.Max(result, temp);
        }

        return result;
    }
}