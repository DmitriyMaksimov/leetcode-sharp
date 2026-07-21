using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03499))]
public class S03499Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03499();
        Assert.That(sut.MaxActiveSectionsAfterTrade("01"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03499();
        Assert.That(sut.MaxActiveSectionsAfterTrade("0100"), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S03499();
        Assert.That(sut.MaxActiveSectionsAfterTrade("1000100"), Is.EqualTo(7));
    }

    [Test]
    public void T4()
    {
        var sut = new S03499();
        Assert.That(sut.MaxActiveSectionsAfterTrade("01010"), Is.EqualTo(4));
    }
}