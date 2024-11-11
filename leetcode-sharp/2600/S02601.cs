namespace leetcode_sharp;

// 2601. Prime Subtraction Operation
// https://leetcode.com/problems/prime-subtraction-operation
public class S02601
{
    public bool PrimeSubOperation(int[] nums)
    {
        var n = nums.Length;
        var isPrime = Enumerable.Repeat(true, 1005).ToArray();

        SieveAlgo(isPrime, isPrime.Length);

        var prime = new List<int>();

        for (var i = 0; i < isPrime.Length - 1; i++)
        {
            if (isPrime[i])
            {
                prime.Add(i);
            }
        }

        var prev = nums[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            if (nums[i] < prev)
            {
                prev = nums[i];
                continue;
            }

            var canReduce = false;

            foreach (var p in prime)
            {
                if (p >= nums[i])
                {
                    break;
                }

                if (nums[i] - p < prev)
                {
                    prev = nums[i] - p;
                    canReduce = true;
                    break;
                }
            }

            if (!canReduce)
            {
                return false;
            }
        }

        return true;
    }

    private static void SieveAlgo(bool[] isPrime, int n)
    {
        isPrime[0] = isPrime[1] = false;

        for (var i = 2; i * i < n; i++)
        {
            for (var j = 2 * i; j < n; j += i)
            {
                isPrime[j] = false;
            }
        }
    }
}
