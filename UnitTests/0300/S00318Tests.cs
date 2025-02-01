using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00318Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00318();
        Assert.That(sut.MaxProduct(["abcw", "baz", "foo", "bar", "xtfn", "abcdef"]), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S00318();
        Assert.That(sut.MaxProduct(["a", "ab", "abc", "d", "cd", "bcd", "abcd"]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00318();
        Assert.That(sut.MaxProduct(["a", "aa", "aaa", "aaaa"]), Is.EqualTo(0));
    }
}
