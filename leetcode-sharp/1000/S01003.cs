namespace leetcode_sharp;

// 1003. Check If Word Is Valid After Substitutions
// https://leetcode.com/problems/check-if-word-is-valid-after-substitutions
public class S01003
{
    public bool IsValid(string s2)
    {
        var charArray = s2.ToCharArray();

        var j = 0;

        for (var i = 0; i < charArray.Length; ++i)
        {
            if (charArray[i] == 'c' && j > 1 && charArray[j - 1] == 'b' && charArray[j - 2] == 'a')
            {
                j -= 2;
            }
            else
            {
                charArray[j++] = charArray[i];
            }
        }

        return j == 0;
    }
}
