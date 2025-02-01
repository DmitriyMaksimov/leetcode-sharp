using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03324Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03324();
        Assert.That(sut.StringSequence("abc"), Is.EqualTo((string[]) ["a", "aa", "ab", "aba", "abb", "abc"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03324();
        Assert.That(sut.StringSequence("he"), Is.EqualTo((string[]) ["a", "b", "c", "d", "e", "f", "g", "h", "ha", "hb", "hc", "hd", "he"]));
    }
}
