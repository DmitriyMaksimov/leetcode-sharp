using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02333))]
public class S02333Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02333();
        Assert.That(sut.MinSumSquareDiff([1, 2, 3, 4], [2, 10, 20, 19], 0, 0), Is.EqualTo(579));
    }

    [Test]
    public void T2()
    {
        var sut = new S02333();
        Assert.That(sut.MinSumSquareDiff([1, 4, 10, 12], [5, 8, 6, 9], 1, 1), Is.EqualTo(43));
    }
}