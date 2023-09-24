using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02490Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02490();
        sut.IsCircularSentence("leetcode exercises sound delightful").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02490();
        sut.IsCircularSentence("eetcode").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02490();
        sut.IsCircularSentence("Leetcode is cool").Should().BeFalse();
    }
}