namespace leetcode_sharp;

// 2511. Maximum Enemy Forts That Can Be Captured
// https://leetcode.com/problems/maximum-enemy-forts-that-can-be-captured/
public class S02511
{
    public int CaptureForts(int[] forts)
    {
        var res = 0;

        for (int i = 0, j = 0; i < forts.Length; ++i)
        {
            if (forts[i] == 0) continue;
            
            if (forts[j] == -forts[i])
            {
                res = Math.Max(res, i - j - 1);
            }

            j = i;
        }

        return res;
    }
}