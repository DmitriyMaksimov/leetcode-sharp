using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03365Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03365();
        Assert.That(sut.IsPossibleToRearrange("abcd", "cdab", 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03365();
        Assert.That(sut.IsPossibleToRearrange("aabbcc", "bbaacc", 3), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03365();
        Assert.That(sut.IsPossibleToRearrange("aabbcc", "bbaacc", 2), Is.False);
    }
}
