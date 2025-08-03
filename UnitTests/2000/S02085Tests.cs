using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02085Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02085();
        Assert.That(sut.CountWords(["leetcode", "is", "amazing", "as", "is"], ["amazing", "leetcode", "is"]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02085();
        Assert.That(sut.CountWords(["b", "bb", "bbb"], ["a", "aa", "aaa"]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02085();
        Assert.That(sut.CountWords(["a", "ab"], ["a", "a", "a", "ab"]), Is.EqualTo(1));
    }
}