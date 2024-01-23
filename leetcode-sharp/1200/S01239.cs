namespace leetcode_sharp;

// 1239. Maximum Length of a Concatenated String with Unique Characters
// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters
public class S01239
{
    public int MaxLength(IList<string> arr)
    {
        return maxLength(arr, 0, "");
    }

    private static int maxLength(IList<string> arr, int n, string s)
    {
        if (s.Distinct().Count() < s.Length)
        {
            return 0;
        }

        return arr.Count == n ? s.Length : Math.Max(maxLength(arr, n + 1, s), maxLength(arr, n + 1, s + arr[n]));
    }
}