using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00384Tests
{
    [Test]
    public void T1()
    {
        var solution = new S00384.Solution([1, 2, 3]);
        solution.Shuffle().Distinct().Should().HaveCount(3);
        Assert.That(solution.Reset(), Is.EqualTo((int[]) [1, 2, 3]));
        solution.Shuffle().Distinct().Should().HaveCount(3);
    }
}
