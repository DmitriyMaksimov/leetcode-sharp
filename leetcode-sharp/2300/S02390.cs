namespace leetcode_sharp;

// 2390. Removing Stars From a String
// https://leetcode.com/problems/removing-stars-from-a-string/
public class S02390
{
    public string RemoveStars(string s)
    {
        var charArray = s.ToCharArray();
        var j = 0;
        for (var i = 0; i < charArray.Length; ++i)
        {
            if (charArray[i] == '*')
            {
                j--;
            }
            else
            {
                charArray[j++] = charArray[i];
            }
        }

        return string.Join("", charArray[..j]);
    }
}