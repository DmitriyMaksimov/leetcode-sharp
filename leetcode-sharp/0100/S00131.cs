namespace leetcode_sharp;

// 131. Palindrome Partitioning
// https://leetcode.com/problems/palindrome-partitioning/
public class S00131
{
    public IList<IList<string>> Partition(string s)
    {
        if (!s.Any())
        {
            return new List<IList<string>>();
        }

        if (s.Length == 1)
        {
            return new List<IList<string>> {new List<string>{s}};
        }
        
        var result = new List<IList<string>>();
        
        for (var i = 1; i <= s.Length; i++)
        {
            var current = s[..i];
            
            if (isPalindrome(current))
            {
                if (i == s.Length)
                {
                    var list = new List<string> {current};
                    result.Add(list);
                    continue;
                }
                foreach (var palindromes in Partition(s[i..]))
                {
                    var list = new List<string> {current};
                    list.AddRange(palindromes);
                    result.Add(list);
                }
            }
        }

        return result;
    }

    private static bool isPalindrome(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1]) return false;
        }

        return true;
    }
}