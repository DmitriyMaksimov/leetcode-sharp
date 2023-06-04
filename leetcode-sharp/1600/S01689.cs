namespace leetcode_sharp;

// 1689. Partitioning Into Minimum Number Of Deci-Binary Numbers
// https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
public class S01689
{
    public int MinPartitions(string n)
    {
        return n.Max() - '0';
    }
}