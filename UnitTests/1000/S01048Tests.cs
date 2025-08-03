using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01048Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01048();
        Assert.That(sut.LongestStrChain(["a", "b", "ba", "bca", "bda", "bdca"]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01048();
        Assert.That(sut.LongestStrChain(["xbc", "pcxbcf", "xb", "cxbc", "pcxbc"]), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01048();
        Assert.That(sut.LongestStrChain(["abcd", "dbqca"]), Is.EqualTo(1));
    }
}