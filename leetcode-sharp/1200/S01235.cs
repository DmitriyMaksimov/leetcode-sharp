namespace leetcode_sharp;

// 1235. Maximum Profit in Job Scheduling
// https://leetcode.com/problems/maximum-profit-in-job-scheduling/description/
public class S01235
{
    private record Job(int Start, int Finish, int Profit);

    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        // get the number of jobs
        var n = startTime.Length;

        // base case
        if (n == 0)
        {
            return 0;
        }

        var jobs = new List<Job>();
        for (var i = 0; i < n; i++)
        {
            jobs.Add(new Job(startTime[i], endTime[i], profit[i]));
        }

        // sort jobs in increasing order of their finish times
        jobs = jobs.OrderBy(x => x.Finish).ToList();

        // construct a lookup table where the i'th index stores the maximum profit for the first `i` jobs
        var maxProfit = new int[n];

        // maximum profit gained by including the first job
        maxProfit[0] = jobs[0].Profit;

        // fill the `maxProfit[]` table in a bottom-up manner from the second index
        for (var i = 1; i < n; i++)
        {
            // find the index of the last non-conflicting job with the current job
            var index = findLastNonConflictingJob(jobs, i);

            // include the current job with its non-conflicting jobs
            var incl = jobs[i].Profit;
            if (index != -1)
            {
                incl += maxProfit[index];
            }

            // store the maximum profit by including or excluding the current job
            maxProfit[i] = Math.Max(incl, maxProfit[i - 1]);
        }

        // return maximum profit
        return maxProfit[n - 1];
    }

    // Function to find the index of the last job which doesn't conflict with the
    // given job. It performs a linear search on the given vector of jobs.
    private static int findLastNonConflictingJob(IReadOnlyList<Job> jobs, int n)
    {
        // find the last job index whose finish time is less than or equal to the given job's start time
        var low = 0;
        var high = n;

        // iterate till the search space is exhausted
        while (low <= high)
        {
            var mid = (low + high) / 2;
            if (jobs[mid].Finish <= jobs[n].Start)
            {
                if (jobs[mid + 1].Finish <= jobs[n].Start)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            else
            {
                high = mid - 1;
            }
        }

        // return the negative index if no non-conflicting job is found
        return -1;
    }
}