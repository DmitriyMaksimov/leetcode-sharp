using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01138Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01138();
        Assert.That(sut.AlphabetBoardPath("leet"), Is.EqualTo("RDD!UURRR!!DDD!"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01138();
        Assert.That(sut.AlphabetBoardPath("code"), Is.EqualTo("RR!RRDD!UUL!R!"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01138();
        Assert.That(sut.AlphabetBoardPath("zdz"), Is.EqualTo("DDDDD!UUUUURRR!LLLDDDDD!"));
    }
}
