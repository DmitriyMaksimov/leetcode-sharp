using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01880Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01880();
        Assert.That(sut.IsSumEqual("acb", "cba", "cdb"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01880();
        Assert.That(sut.IsSumEqual("aaa", "a", "aab"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01880();
        Assert.That(sut.IsSumEqual("aaa", "a", "aaaa"), Is.True);
    }
}
