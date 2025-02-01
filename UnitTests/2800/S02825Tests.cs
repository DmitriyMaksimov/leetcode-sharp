using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02825Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02825();
        Assert.That(sut.CanMakeSubsequence("abc", "ad"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02825();
        Assert.That(sut.CanMakeSubsequence("zc", "ad"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02825();
        Assert.That(sut.CanMakeSubsequence("ab", "d"), Is.False);
    }
}
