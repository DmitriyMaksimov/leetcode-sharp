namespace leetcode_sharp._2000;

// 2011. Final Value of Variable After Performing Operations
// https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
public class S02011
{
    public int FinalValueAfterOperations(string[] operations)
    {
        return operations.Sum(operation => operation[1] == '+' ? 1 : -1);
    }
}