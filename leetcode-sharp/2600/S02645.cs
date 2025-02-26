namespace leetcode_sharp;

// 2645. Minimum Additions to Make Valid String
// https://leetcode.com/problems/minimum-additions-to-make-valid-string
public class S02645
{
    public int AddMinimum(string word)
    {
        var n = word.Length;
        var result = 0;

        for (var i = 0; i < n;)
        {
            var count = 0;

            if (word[i] == 'a')
            {
                count++;
                i++;
            }

            if (i < n && word[i] == 'b')
            {
                count++;
                i++;
            }

            if (i < n && word[i] == 'c')
            {
                count++;
                i++;
            }

            result += 3 - count;
        }

        return result;
    }
}
