using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01048Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01048();
        sut.LongestStrChain(new[] {"a", "b", "ba", "bca", "bda", "bdca"}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01048();
        sut.LongestStrChain(new[] {"xbc", "pcxbcf", "xb", "cxbc", "pcxbc"}).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01048();
        sut.LongestStrChain(new[] {"abcd", "dbqca"}).Should().Be(1);
    }
}