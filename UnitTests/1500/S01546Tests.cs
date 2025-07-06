using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01546))]
public class S01546Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01546();
        Assert.That(sut.MaxNonOverlapping([1, 1, 1, 1, 1], 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01546();
        Assert.That(sut.MaxNonOverlapping([-1, 3, 5, 1, 4, 2, -9], 6), Is.EqualTo(2));
    }
}