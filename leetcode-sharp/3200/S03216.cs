namespace leetcode_sharp;

// 3216. Lexicographically Smallest String After a Swap
// https://leetcode.com/problems/lexicographically-smallest-string-after-a-swap
public class S03216
{
    public string GetSmallestString(string s)
    {
        var charArray = s.ToCharArray();

        for (var i = 0; i < charArray.Length - 1; i++)
        {
            if (SameParity(charArray[i], charArray[i + 1]) && charArray[i] > charArray[i + 1])
            {
                (charArray[i], charArray[i + 1]) = (charArray[i + 1], charArray[i]);
                break;
            }
        }

        return new string(charArray);
    }

    private static bool SameParity(char c1, char c2)
    {
        return c1 % 2 == c2 % 2;
    }
}