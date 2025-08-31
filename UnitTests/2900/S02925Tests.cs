using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02925))]
public class S02925Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02925();
        Assert.That(sut.MaximumScoreAfterOperations([[0, 1], [0, 2], [0, 3], [2, 4], [4, 5]], [5, 2, 5, 2, 1, 1]), Is.EqualTo(11));
    }

    [Test]
    public void T2()
    {
        var sut = new S02925();
        Assert.That(sut.MaximumScoreAfterOperations([[0, 1], [0, 2], [1, 3], [1, 4], [2, 5], [2, 6]], [20, 10, 9, 7, 4, 3, 5]), Is.EqualTo(40));
    }
}