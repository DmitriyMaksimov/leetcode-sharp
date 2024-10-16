namespace leetcode_sharp;

// 2947. Count Beautiful Substrings I
// https://leetcode.com/problems/count-beautiful-substrings-i
public class S02947
{
    private readonly HashSet<char> _vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public int BeautifulSubstrings(string s, int k)
    {
        var result = 0;

        for (var i = 0; i < s.Length; ++i)
        {
            var vowels = 0;
            var con = 0;

            for (int j = i; j < s.Length; ++j)
            {
                if (_vowels.Contains(s[j]))
                {
                    vowels++;
                }
                else
                {
                    con++;
                }

                if (vowels == con && vowels * con % k == 0)
                {
                    result++;
                }
            }
        }

        return result;
    }
}
