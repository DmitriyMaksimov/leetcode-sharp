using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03324Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03324();
        sut.StringSequence("abc").Should().Equal("a", "aa", "ab", "aba", "abb", "abc");
    }

    [Test]
    public void T2()
    {
        var sut = new S03324();
        sut.StringSequence("he").Should().Equal("a", "b", "c", "d", "e", "f", "g", "h", "ha", "hb", "hc", "hd", "he");
    }
}
