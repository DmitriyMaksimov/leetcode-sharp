using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00935Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00935();
        Assert.That(sut.KnightDialer(1), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S00935();
        Assert.That(sut.KnightDialer(2), Is.EqualTo(20));
    }

    [Test]
    public void T3()
    {
        var sut = new S00935();
        Assert.That(sut.KnightDialer(3131), Is.EqualTo(136006598));
    }
}