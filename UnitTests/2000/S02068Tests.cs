using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02068Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02068();
        Assert.That(sut.CheckAlmostEquivalent("aaaa", "bccb"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S02068();
        Assert.That(sut.CheckAlmostEquivalent("abcdeef", "abaaacc"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02068();
        Assert.That(sut.CheckAlmostEquivalent("cccddabba", "babababab"), Is.True);
    }
}
