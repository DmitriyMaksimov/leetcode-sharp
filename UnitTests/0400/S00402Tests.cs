using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00402Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00402();
        sut.RemoveKdigits("1432219", 3).Should().Be("1219");
    }

    [Test]
    public void T2()
    {
        var sut = new S00402();
        sut.RemoveKdigits("10200", 1).Should().Be("200");
    }

    [Test]
    public void T3()
    {
        var sut = new S00402();
        sut.RemoveKdigits("10", 2).Should().Be("0");
    }
}