namespace leetcode_sharp;

// 3629. Minimum Jumps to Reach End via Prime Teleportation
// https://leetcode.com/problems/minimum-jumps-to-reach-end-via-prime-teleportation
public class S03629
{
    private static readonly bool[] IsPrime = Enumerable.Repeat(true, 1_000_001).ToArray();
    private static bool _sieveBuilt;

    private void InitializeSieve()
    {
        IsPrime[0] = false;
        IsPrime[1] = false;

        for (var i = 2; i * i <= 1_000_000; ++i)
        {
            if (!IsPrime[i])
            {
                continue;
            }

            for (var j = i * i; j <= 1_000_000; j += i)
            {
                IsPrime[j] = false;
            }
        }

        _sieveBuilt = true;
    }

    public int MinJumps(int[] nums)
    {
        if (!_sieveBuilt)
        {
            InitializeSieve();
        }

        var n = nums.Length;
        var maxi = nums.Max();
        var mp = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
        {
            if (!mp.ContainsKey(nums[i]))
            {
                mp[nums[i]] = [];
            }

            mp[nums[i]].Add(i);
        }

        var dist = Enumerable.Repeat(-1, n).ToArray();
        var queue = new Queue<int>();
        queue.Enqueue(0);
        dist[0] = 0;

        var used = new HashSet<int>();

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node - 1 >= 0 && dist[node - 1] == -1)
            {
                queue.Enqueue(node - 1);
                dist[node - 1] = dist[node] + 1;
            }

            if (node + 1 < n && dist[node + 1] == -1)
            {
                queue.Enqueue(node + 1);
                dist[node + 1] = dist[node] + 1;
            }

            if (!IsPrime[nums[node]] || used.Contains(nums[node]))
            {
                continue;
            }

            for (var tar = nums[node]; tar <= maxi; tar += nums[node])
            {
                if (!mp.ContainsKey(tar))
                {
                    continue;
                }

                foreach (var it in mp[tar])
                {
                    if (dist[it] != -1)
                    {
                        continue;
                    }

                    queue.Enqueue(it);

                    if (it == n - 1)
                    {
                        return dist[node] + 1;
                    }

                    dist[it] = dist[node] + 1;
                }
            }

            used.Add(nums[node]);
        }

        return dist[n - 1];
    }
}