using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02085Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02085();
        sut.CountWords(new[] {"leetcode", "is", "amazing", "as", "is"}, new[] {"amazing", "leetcode", "is"}).Should()
            .Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02085();
        sut.CountWords(new[] {"b", "bb", "bbb"}, new[] {"a", "aa", "aaa"}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02085();
        sut.CountWords(new[] {"a", "ab"}, new[] {"a", "a", "a", "ab"}).Should().Be(1);
    }
}