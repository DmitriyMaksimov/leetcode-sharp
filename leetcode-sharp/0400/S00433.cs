namespace leetcode_sharp;

// 433. Minimum Genetic Mutation
// https://leetcode.com/problems/minimum-genetic-mutation/
public class S00433
{
    public int MinMutation(string startGene, string endGene, string[] bank)
    {
        var q = new Queue<string>();
        var visited = new HashSet<string>();

        q.Enqueue(startGene);
        visited.Add(startGene);

        var mutations = 0;
        var foundSolution = false;

        while (q.Count > 0 && !foundSolution)
        {
            var iterationCount = q.Count;

            for (var i = 0; i < iterationCount && !foundSolution; i++)
            {
                var c = q.Dequeue();

                for (var j = 0; j < bank.Length && !foundSolution; j++)
                {
                    if (visited.Contains(bank[j]))
                    {
                        continue;
                    }

                    var diffs = 0;
                    for (var k = 0; k < 8 && diffs <= 1; k++)
                    {
                        if (c[k] != bank[j][k])
                        {
                            diffs++;
                        }
                    }

                    if (diffs == 1)
                    {
                        if (bank[j] == endGene)
                        {
                            foundSolution = true;
                        }
                        else
                        {
                            q.Enqueue(bank[j]);
                            visited.Add(bank[j]);
                        }
                    }
                }
            }

            mutations++;
        }

        if (!foundSolution)
        {
            return -1;
        }

        return mutations;
    }
}