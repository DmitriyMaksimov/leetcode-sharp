namespace leetcode_sharp;

// 278. First Bad Version
// https://leetcode.com/problems/first-bad-version/
public class S00278
{
    private readonly int _bad;

    public S00278(int bad)
    {
        _bad = bad;
    }
    bool IsBadVersion(int version)
    {
        return version >= _bad;
    }
    
    public int FirstBadVersion(int n)
    {
        var l = 1;
        var r = n;

        while (l <= r)
        {
            var m = l + (r - l) / 2;
            if (IsBadVersion(m))
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return l;
    }
}