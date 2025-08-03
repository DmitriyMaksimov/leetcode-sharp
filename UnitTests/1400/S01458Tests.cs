using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01458Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01458();
        Assert.That(sut.MaxDotProduct([2, 1, -2, 5], [3, 0, -6]), Is.EqualTo(18));
    }

    [Test]
    public void T2()
    {
        var sut = new S01458();
        Assert.That(sut.MaxDotProduct([3, -2], [2, -6, 7]), Is.EqualTo(21));
    }

    [Test]
    public void T3()
    {
        var sut = new S01458();
        Assert.That(sut.MaxDotProduct([-1, -1], [1, 1]), Is.EqualTo(-1));
    }
}