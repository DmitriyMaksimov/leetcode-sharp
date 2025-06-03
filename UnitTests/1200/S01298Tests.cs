using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01298))]
public class S01298Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01298();
        Assert.That(sut.MaxCandies([1, 0, 1, 0], [7, 5, 4, 100], [[], [], [1], []], [[1, 2], [3], [], []], [0]), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S01298();
        Assert.That(sut.MaxCandies([1, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1], [[1, 2, 3, 4, 5], [], [], [], [], []], [[1, 2, 3, 4, 5], [], [], [], [], []], [0]), Is.EqualTo(6));
    }
}
