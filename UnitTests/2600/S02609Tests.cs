using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02609Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02609();
        sut.FindTheLongestBalancedSubstring("01000111").Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02609();
        sut.FindTheLongestBalancedSubstring("00111").Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02609();
        sut.FindTheLongestBalancedSubstring("111").Should().Be(0);
    }
}