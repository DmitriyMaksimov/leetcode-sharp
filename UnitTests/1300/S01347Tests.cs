using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01347Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01347();
        sut.MinSteps("bab", "aba").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01347();
        sut.MinSteps("leetcode", "practice").Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01347();
        sut.MinSteps("anagram", "mangaar").Should().Be(0);
    }
}