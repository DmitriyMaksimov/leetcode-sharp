namespace leetcode_sharp;

// 2516. Take K of Each Character From Left and Right
// https://leetcode.com/problems/take-k-of-each-character-from-left-and-right
public class S02516
{
    public int TakeCharacters(string s, int k)
    {
        var limits = new Dictionary<char, int>
        {
            { 'a', s.Count(c => c == 'a') - k },
            { 'b', s.Count(c => c == 'b') - k },
            { 'c', s.Count(c => c == 'c') - k }
        };

        if (limits.Values.Any(x => x < 0))
        {
            return -1;
        }

        var counts = new Dictionary<char, int> { { 'a', 0 }, { 'b', 0 }, { 'c', 0 } };
        var result = 0;
        var left = 0;

        for (var right = 0; right < s.Length; right++)
        {
            var c = s[right];
            counts[c]++;
            while (counts[c] > limits[c])
            {
                counts[s[left]]--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return s.Length - result;
    }
}
