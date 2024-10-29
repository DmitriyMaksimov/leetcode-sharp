using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00318Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00318();
        sut.MaxProduct(["abcw", "baz", "foo", "bar", "xtfn", "abcdef"]).Should().Be(16);
    }

    [Test]
    public void T2()
    {
        var sut = new S00318();
        sut.MaxProduct(["a", "ab", "abc", "d", "cd", "bcd", "abcd"]).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00318();
        sut.MaxProduct(["a", "aa", "aaa", "aaaa"]).Should().Be(0);
    }
}
