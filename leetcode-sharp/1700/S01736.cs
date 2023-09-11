namespace leetcode_sharp;

// 1736. Latest chars by Replacing Hidden Digits
// https://leetcode.com/problems/latest-chars-by-replacing-hidden-digits/
public class S01736
{
    public string MaximumTime(string time)
    {
        var chars = time.ToCharArray();

        chars[0] = chars[0] != '?' ? chars[0] : (chars[1] == '?' || chars[1] <= '3') ? '2' : '1';
        chars[1] = chars[1] != '?' ? chars[1] : chars[0] == '2' ? '3' : '9';
        chars[3] = chars[3] != '?' ? chars[3] : '5';
        chars[4] = chars[4] != '?' ? chars[4] : '9';

        return new string(chars);
    }
}