using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02957Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02957();
        Assert.That(sut.RemoveAlmostEqualCharacters("aaaaa"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02957();
        Assert.That(sut.RemoveAlmostEqualCharacters("abddez"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02957();
        Assert.That(sut.RemoveAlmostEqualCharacters("zyxyxyz"), Is.EqualTo(3));
    }
}
