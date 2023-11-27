namespace leetcode_sharp;

// 935. Knight Dialer
// https://leetcode.com/problems/knight-dialer
public class S00935
{
    private const long Mod = 1_000_000_007;

    public int KnightDialer(int n)
    {
        var result = new long[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
        var temp = new long[10];

        for (var i = 1; i < n; i++)
        {
            for (var j = 0; j < temp.Length; j++)
            {
                temp[j] = getNumberOfNumbers(j, result) % Mod;
            }

            for (var j = 0; j < temp.Length; j++)
            {
                result[j] = temp[j];
            }
        }

        return (int) (result.Sum() % Mod);
    }

    private long getNumberOfNumbers(int n, IReadOnlyList<long> nums)
    {
        return n switch
        {
            0 => nums[4] + nums[6],
            1 => nums[6] + nums[8],
            2 => nums[7] + nums[9],
            3 => nums[4] + nums[8],
            4 => nums[3] + nums[9] + nums[0],
            6 => nums[1] + nums[7] + nums[0],
            7 => nums[2] + nums[6],
            8 => nums[1] + nums[3],
            9 => nums[2] + nums[4],
            _ => 0
        };
    }
}