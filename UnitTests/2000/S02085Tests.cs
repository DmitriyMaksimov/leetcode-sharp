using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02085Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02085();
        Assert.That(sut.CountWords(new[] {"leetcode", "is", "amazing", "as", "is"}, new[] {"amazing", "leetcode", "is"}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02085();
        Assert.That(sut.CountWords(new[] {"b", "bb", "bbb"}, new[] {"a", "aa", "aaa"}), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02085();
        Assert.That(sut.CountWords(new[] {"a", "ab"}, new[] {"a", "a", "a", "ab"}), Is.EqualTo(1));
    }
}