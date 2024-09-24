namespace leetcode_sharp;

// 3043. Find the Length of the Longest Common Prefix
// https://leetcode.com/problems/find-the-length-of-the-longest-common-prefix
public class S03043
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        Dictionary<string, int> prefixMap = [];

        foreach (var num in arr1)
        {
            var strNum = num.ToString();
            var prefix = "";

            foreach (var ch in strNum)
            {
                prefix += ch;
                prefixMap[prefix] = prefixMap.GetValueOrDefault(prefix, 0) + 1;
            }
        }

        var maxLength = 0;

        foreach (var num in arr2)
        {
            var strNum = num.ToString();
            var prefix = "";

            foreach (var ch in strNum)
            {
                prefix += ch;
                if (prefixMap.ContainsKey(prefix))
                {
                    maxLength = Math.Max(maxLength, prefix.Length);
                }
            }
        }

        return maxLength;
    }
}
