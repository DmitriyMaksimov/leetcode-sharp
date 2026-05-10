using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02770))]
public class S02770Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02770();
        Assert.That(sut.MaximumJumps([1, 3, 6, 4, 1, 2], 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02770();
        Assert.That(sut.MaximumJumps([1, 3, 6, 4, 1, 2], 3), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S02770();
        Assert.That(sut.MaximumJumps([1, 3, 6, 4, 1, 2], 0), Is.EqualTo(-1));
    }
}