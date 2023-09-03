using System.Text;

namespace leetcode_sharp;

// 824. Goat Latin
// https://leetcode.com/problems/goat-latin/
public class S00824
{
    public string ToGoatLatin(string sentence)
    {
        var words = sentence.Split(' ');
        var sb = new StringBuilder();
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (vowels.Contains(char.ToLower(word[0])))
            {
                sb.Append(word);
            }
            else
            {
                sb.Append(word[1..]);
                sb.Append(word[0]);
            }

            sb.Append("ma");
            sb.Append('a', i + 1);
            if (i != words.Length - 1)
            {
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }
}