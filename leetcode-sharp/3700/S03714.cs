namespace leetcode_sharp;

// 3714. Longest Balanced Substring II
// https://leetcode.com/problems/longest-balanced-substring-ii
public class S03714
{
    public int LongestBalanced(string s)
    {
        var n = s.Length;
        var result = 1;
        var len = 1;

        for (var i = 1; i < n; i++)
        {
            if (s[i] == s[i - 1])
            {
                len++;
            }
            else
            {
                result = Math.Max(result, len);
                len = 1;
            }
        }

        result = Math.Max(result, len);

        result = FindMaxBalancedLength(s, 'a', 'b', result);
        result = FindMaxBalancedLength(s, 'b', 'c', result);
        result = FindMaxBalancedLength(s, 'a', 'c', result);

        var map = new Dictionary<(int, int), int>
        {
            [(0, 0)] = -1
        };

        var count = new int[3];

        for (var i = 0; i < n; i++)
        {
            count[s[i] - 'a']++;

            var countAB = count[0] - count[1];
            var countAC = count[0] - count[2];

            var key = (countAB, countAC);

            if (map.TryGetValue(key, out var firstIndex))
            {
                result = Math.Max(result, i - firstIndex);
            }
            else
            {
                map[key] = i;
            }
        }

        return result;
    }

    private static int FindMaxBalancedLength(string s, char x, char y, int currentMax)
    {
        var sum = 0;
        var map = new Dictionary<int, int>
        {
            [0] = -1
        };

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == x)
            {
                sum++;
            }
            else if (s[i] == y)
            {
                sum--;
            }
            else
            {
                map.Clear();
                map[0] = i;
                sum = 0;
                continue;
            }

            if (map.TryGetValue(sum, out var firstIndex))
            {
                currentMax = Math.Max(currentMax, i - firstIndex);
            }
            else
            {
                map[sum] = i;
            }
        }

        return currentMax;
    }
}