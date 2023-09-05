namespace leetcode_sharp;

// 942. DI String Match
// https://leetcode.com/problems/di-string-match/
public class S00942
{
    public int[] DiStringMatch(string s)
    {
        var result = new int[s.Length + 1];
        var min = 0;
        var max = s.Length;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                result[i] = min++;
            }
            else
            {
                result[i] = max--;
            }
        }
        
        result[^1] = min;

        return result;
    }
}