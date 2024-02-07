using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00890Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00890();
        sut.FindAndReplacePattern(["abc", "deq", "mee", "aqq", "dkd", "ccc"], "abb").Should().Equal("mee", "aqq");
    }

    [Test]
    public void T2()
    {
        var sut = new S00890();
        sut.FindAndReplacePattern(["a", "b", "c"], "a").Should().Equal("a", "b", "c");
    }
}