using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01237Tests
{
    private class CustomFunction1 : S01237.CustomFunction
    {
        public override int f(int x, int y)
        {
            return x + y;
        }
    }

    private class CustomFunction2 : S01237.CustomFunction
    {
        public override int f(int x, int y)
        {
            return x * y;
        }
    }

    [Test]
    public void T1()
    {
        var customFunction = new CustomFunction1();
        var sut = new S01237();
        Assert.That(sut.FindSolution(customFunction, 5), Is.EquivalentTo((int[][]) [[1, 4], [2, 3], [3, 2], [4, 1]]));
    }

    [Test]
    public void T2()
    {
        var customFunction = new CustomFunction2();
        var sut = new S01237();
        Assert.That(sut.FindSolution(customFunction, 5), Is.EquivalentTo((int[][]) [[1, 5], [5, 1]]));
    }
}
