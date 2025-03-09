using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03456Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03456();
        Assert.That(sut.HasSpecialSubstring("aaabaaa", 3), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03456();
        Assert.That(sut.HasSpecialSubstring("abc", 2), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03456();
        Assert.That(sut.HasSpecialSubstring("h", 1), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S03456();
        Assert.That(sut.HasSpecialSubstring("dii", 1), Is.True);
    }
}
