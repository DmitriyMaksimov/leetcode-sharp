using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02609Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02609();
        Assert.That(sut.FindTheLongestBalancedSubstring("01000111"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02609();
        Assert.That(sut.FindTheLongestBalancedSubstring("00111"), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S02609();
        Assert.That(sut.FindTheLongestBalancedSubstring("111"), Is.EqualTo(0));
    }
}