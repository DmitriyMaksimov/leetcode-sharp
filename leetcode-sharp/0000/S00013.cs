namespace leetcode_sharp;

// 13. Roman to Integer
// https://leetcode.com/problems/roman-to-integer/
public class S00013
{
    private readonly Dictionary<char, int> _m = new() {{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};

    public int RomanToInt(string s)
    {
        var answer = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && _m[s[i]] < _m[s[i + 1]])
            {
                answer -= _m[s[i]];
            }
            else
            {
                answer += _m[s[i]];
            }
        }

        return answer;
    }
}