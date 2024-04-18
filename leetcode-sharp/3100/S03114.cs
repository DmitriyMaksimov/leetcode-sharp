namespace leetcode_sharp;

// 3114. Latest Time You Can Obtain After Replacing Characters
// https://leetcode.com/problems/latest-time-you-can-obtain-after-replacing-characters
public class S03114
{
    public string FindLatestTime(string s)
    {
        var chars = s.ToCharArray();

        chars[0] = chars[0] != '?' ? chars[0] : (chars[1] == '?' || chars[1] <= '1') ? '1' : '0';
        chars[1] = chars[1] != '?' ? chars[1] : chars[0] == '1' ? '1' : '9';
        chars[3] = chars[3] != '?' ? chars[3] : '5';
        chars[4] = chars[4] != '?' ? chars[4] : '9';

        return new string(chars);
    }
}