namespace leetcode_sharp;

// 2933. High-Access Employees
// https://leetcode.com/problems/high-access-employees
public class S02933
{
    public IList<string> FindHighAccessEmployees(IList<IList<string>> accessTimes)
    {
        var n = accessTimes.Count;

        // Sort by employee then by time
        var sorted = new List<IList<string>>(accessTimes);
        sorted.Sort((a, b) =>
        {
            var nameCompare = string.Compare(a[0], b[0], StringComparison.Ordinal);
            return nameCompare != 0
                ? nameCompare
                : string.Compare(a[1], b[1], StringComparison.Ordinal);
        });

        var result = new List<string>();
        var seen = new HashSet<string>();

        for (var i = 0; i < n - 2; i++)
        {
            var employee = sorted[i][0];

            if (seen.Contains(employee))
            {
                continue;
            }

            if (employee == sorted[i + 2][0])
            {
                var t1 = int.Parse(sorted[i][1]);
                var t2 = int.Parse(sorted[i + 2][1]);

                if (t2 - t1 < 100)
                {
                    seen.Add(employee);
                    result.Add(employee);
                }
            }
        }

        return result;
    }
}