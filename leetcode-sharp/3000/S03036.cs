namespace leetcode_sharp;

// 3036. Number of Subarrays That Match a Pattern II
// https://leetcode.com/problems/number-of-subarrays-that-match-a-pattern-ii
public class S03036
{
    private const int Base = 5;
    private const int Prime = 1_000_000_000 + 9;
    private long _power = 1;

    public int CountMatchingSubarrays(int[] nums, int[] pattern)
    {
        for (var i = 0; i < pattern.Length - 1; ++i)
        {
            _power = _power * Base % Prime;
        }

        var s = new List<char>();
        var p = new List<char>();

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] > nums[i])
            {
                s.Add('1');
            }
            else if (nums[i + 1] == nums[i])
            {
                s.Add('2');
            }
            else
            {
                s.Add('3');
            }
        }

        foreach (var ch in pattern)
        {
            switch (ch)
            {
                case 1:
                    p.Add('1');
                    break;
                case 0:
                    p.Add('2');
                    break;
                default:
                    p.Add('3');
                    break;
            }
        }

        return Count(new string(s.ToArray()), new string(p.ToArray()));
    }

    private static long CharToNumber(char ch)
    {
        return ch switch
        {
            '1' => 1,
            '2' => 2,
            _ => 3
        };
    }

    private static long RollingHash(string s)
    {
        long hashValue = 0;

        foreach (var ch in s)
        {
            hashValue = (hashValue * Base) % Prime;
            hashValue = (hashValue + CharToNumber(ch)) % Prime;
        }

        return hashValue;
    }

    private long UpdateHash(long oldHash, char oldChar, char newChar)
    {
        var oldCharValue = CharToNumber(oldChar);
        var newCharValue = CharToNumber(newChar);
        var newHash = ((oldHash - oldCharValue * _power) * Base + newCharValue) % Prime;
        return (newHash + Prime) % Prime; // Ensure result is positive
    }

    private int Count(string s, string p)
    {
        var hashP = RollingHash(p);
        var ss = s[..p.Length];
        var hashS = RollingHash(ss);
        var ans = hashP == hashS ? 1 : 0;

        for (var i = p.Length; i < s.Length; i++)
        {
            hashS = UpdateHash(hashS, s[i - p.Length], s[i]);
            ans += hashP == hashS ? 1 : 0;
        }

        return ans;
    }
}