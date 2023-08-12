namespace leetcode_sharp;

// 76. Minimum Window Substring
// https://leetcode.com/problems/minimum-window-substring/
public class S00076
{
    public string MinWindow(string s, string t)
    {
        if (s.Length == 0 || t.Length == 0)
        {
            return "";
        }

        var bank = new int[256];

        var left = 0;
        var right = 0;
        var count = 0;

        var min = int.MaxValue;
        var minString = "";

        var pLength = t.Length;
        var length = s.Length;

        for (var i = 0; i < pLength; i++)
        {
            bank[t[i]]++;
        }

        while (right < length)
        {
            var rightChar = s[right++];
            if (bank[rightChar] > 0)
            {
                count++;
            }

            bank[rightChar]--;

            while (count == pLength)
            {
                var size = right - left;
                if (min > size)
                {
                    min = size;
                    minString = s.Substring(left, right - left);
                }

                var leftChar = s[left++];
                bank[leftChar]++;

                if (bank[leftChar] > 0)
                {
                    count--;
                }
            }
        }

        return minString;
    }
}