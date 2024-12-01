namespace leetcode_sharp;

// 2840. Check if Strings Can be Made Equal With Operations II
// https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-ii
public class S02840
{
    public bool CheckStrings(string s1, string s2)
    {
        const int maxChars = 26;

        if (s1.Equals(s2))
        {
            return true;
        }

        var oddCount = new int[maxChars];
        var evenCount = new int[maxChars];

        for (var i = 0; i < s1.Length; i++)
        {
            if (i % 2 == 1)
            {
                oddCount[s1[i] - 'a']++;
                oddCount[s2[i] - 'a']--;
            }
            else
            {
                evenCount[s1[i] - 'a']++;
                evenCount[s2[i] - 'a']--;
            }
        }

        for (var i = 0; i < maxChars; i++)
        {
            if (oddCount[i] != 0 || evenCount[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}
