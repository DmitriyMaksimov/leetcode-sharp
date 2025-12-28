using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03783))]
public class S03783Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03783();
        Assert.That(sut.MirrorDistance(25), Is.EqualTo(27));
    }

    [Test]
    public void T2()
    {
        var sut = new S03783();
        Assert.That(sut.MirrorDistance(10), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S03783();
        Assert.That(sut.MirrorDistance(7), Is.Zero);
    }
}