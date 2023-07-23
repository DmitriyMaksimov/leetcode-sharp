namespace leetcode_sharp;

// 839. Similar String Groups
// https://leetcode.com/problems/similar-string-groups/
public class S00839
{
    public int NumSimilarGroups(string?[] strs)
    {
        if (strs.Length < 2)
        {
            return strs.Length;
        }

        var res = 0;
        
        for (var i = 0; i < strs.Length; i++)
        {
            if (strs[i] == null)
            {
                continue;
            }

            var str = strs[i];
            strs[i] = null;
            res++;
            dfs(strs, str);
        }

        return res;
    }

    private static void dfs(string?[] arr, string str)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == null)
            {
                continue;
            }

            if (similar(str, arr[i]))
            {
                // both string str and arr[i] belong in same group
                var s = arr[i];
                arr[i] = null;
                dfs(arr, s);
            }
        }
    }

    private static bool similar(string s, string t)
    {
        var diff = s.Where((t1, i) => t1 != t[i]).Count();
        return diff <= 2;
    }
}