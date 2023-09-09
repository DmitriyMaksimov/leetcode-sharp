namespace leetcode_sharp;

// 1576. Replace All ?'s to Avoid Consecutive Repeating Characters
// https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/
public class S01576
{
    public string ModifyString(string s)
    {
        var chars = s.ToCharArray();

        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] != '?') continue;
            
            var left = i == 0 ? ' ' : chars[i - 1];
            var right = i == chars.Length - 1 ? ' ' : chars[i + 1];
            var c = 'a';
            while (c == left || c == right)
            {
                c++;
            }

            chars[i] = c;
        }

        return new string(chars);
    }
}