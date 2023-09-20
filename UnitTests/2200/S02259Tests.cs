using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02259Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02259();
        sut.RemoveDigit("123", '3').Should().Be("12");
    }

    [Test]
    public void T2()
    {
        var sut = new S02259();
        sut.RemoveDigit("1231", '1').Should().Be("231");
    }

    [Test]
    public void T3()
    {
        var sut = new S02259();
        sut.RemoveDigit("551", '5').Should().Be("51");
    }
}