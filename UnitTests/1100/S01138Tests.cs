using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01138Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01138();
        sut.AlphabetBoardPath("leet").Should().Be("RDD!UURRR!!DDD!");
    }

    [Test]
    public void T2()
    {
        var sut = new S01138();
        sut.AlphabetBoardPath("code").Should().Be("RR!RRDD!UUL!R!");
    }

    [Test]
    public void T3()
    {
        var sut = new S01138();
        sut.AlphabetBoardPath("zdz").Should().Be("DDDDD!UUUUURRR!LLLDDDDD!");
    }
}
