namespace leetcode_sharp;

// 2582. Pass the Pillow
// https://leetcode.com/problems/pass-the-pillow
public class S02582
{
    public int PassThePillow(int n, int time)
    {
        var turns = time / (n - 1);
        
        time %= n - 1;

        if (turns % 2 == 0)
        {
            return 1 + time;
        }

        return n - time;
    }
}