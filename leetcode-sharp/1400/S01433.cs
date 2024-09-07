namespace leetcode_sharp;

// 1433. Check If a String Can Break Another String
// https://leetcode.com/problems/check-if-a-string-can-break-another-string
public class S01433
{
    public bool CheckIfCanBreak(string s1, string s2)
    {
        var ch1 = s1.ToCharArray();
        var ch2 = s2.ToCharArray();
        var index = 0;
        Array.Sort(ch1);
        Array.Sort(ch2);

        while (ch1[index] == ch2[index])
        {
            index++;
        }

        if (index == s1.Length)
        {
            return true;
        }

        var temp = ch1[index] > ch2[index];

        while (index < s1.Length)
        {
            if (ch1[index] != ch2[index] && ch1[index] > ch2[index] != temp)
            {
                return false;
            }

            index++;
        }

        return true;
    }
}
