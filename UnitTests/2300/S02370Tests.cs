using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02370Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02370();
        sut.LongestIdealString("acfgbd", 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02370();
        sut.LongestIdealString("abcd", 3).Should().Be(4);
    }
}