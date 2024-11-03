using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02414();
        sut.LongestContinuousSubstring("abacaba").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02414();
        sut.LongestContinuousSubstring("abcde").Should().Be(5);
    }
}
