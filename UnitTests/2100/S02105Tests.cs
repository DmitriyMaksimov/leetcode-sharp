using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02105))]
public class S02105Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02105();
        Assert.That(sut.MinimumRefill([2, 2, 3, 3], 5, 5), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02105();
        Assert.That(sut.MinimumRefill([2, 2, 3, 3], 3, 4), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02105();
        Assert.That(sut.MinimumRefill([5], 10, 8), Is.EqualTo(0));
    }
}