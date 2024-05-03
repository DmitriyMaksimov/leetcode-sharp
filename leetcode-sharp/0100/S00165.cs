namespace leetcode_sharp;

// 165. Compare Version Numbers
// https://leetcode.com/problems/compare-version-numbers
public class S00165
{
    public int CompareVersion(string version1, string version2)
    {
        var versionParts1 = version1.Split(".");
        var versionParts2 = version2.Split(".");

        var length = Math.Max(versionParts1.Length, versionParts2.Length);
        
        for (var i = 0; i < length; i++)
        {
            var v1 = i < versionParts1.Length ? int.Parse(versionParts1[i]) : 0;
            var v2 = i < versionParts2.Length ? int.Parse(versionParts2[i]) : 0;

            if (v1 != v2)
            {
                return v1 < v2 ? -1 : 1;
            }
        }

        return 0;
    }
}