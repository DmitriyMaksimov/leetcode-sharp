using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03106Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03106();
        sut.GetSmallestString("zbbz", 3).Should().Be("aaaz");
    }

    [Test]
    public void T2()
    {
        var sut = new S03106();
        sut.GetSmallestString("xaxcd", 4).Should().Be("aawcd");
    }

    [Test]
    public void T3()
    {
        var sut = new S03106();
        sut.GetSmallestString("lol", 0).Should().Be("lol");
    }
}
