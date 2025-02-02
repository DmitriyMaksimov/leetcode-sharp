namespace leetcode_sharp;

// 990. Satisfiability of Equality Equations
// https://leetcode.com/problems/satisfiability-of-equality-equations
public class S00990
{
    private readonly int[] _unionFind = Enumerable.Repeat(-1, 26 + 1).ToArray();

    public bool EquationsPossible(string[] equations)
    {
        foreach (var equation in equations.Where(equation => equation[1] == '='))
        {
            _unionFind[UnionFind(equation[0] - 'a')] = UnionFind(equation[3] - 'a');
        }

        return equations.Where(equation => equation[1] == '!').All(equation => UnionFind(equation[0] - 'a') != UnionFind(equation[3] - 'a'));
    }

    private int UnionFind(int n)
    {
        return _unionFind[n] == -1 || _unionFind[n] == n ? n : _unionFind[n] = UnionFind(_unionFind[n]);
    }
}
