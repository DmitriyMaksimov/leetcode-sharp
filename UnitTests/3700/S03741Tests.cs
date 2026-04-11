using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03741))]
public class S03741Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03741();
        Assert.That(sut.MinimumDistance([1, 2, 1, 1, 3]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03741();
        Assert.That(sut.MinimumDistance([1, 1, 2, 3, 2, 1, 2]), Is.EqualTo(8));
    }

    [Test]
    public void T3()
    {
        var sut = new S03741();
        Assert.That(sut.MinimumDistance([1]), Is.EqualTo(-1));
    }
}