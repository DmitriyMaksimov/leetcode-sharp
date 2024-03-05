using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01750Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01750();
        sut.MinimumLength("ca").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01750();
        sut.MinimumLength("cabaabac").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01750();
        sut.MinimumLength("aabccabba").Should().Be(3);
    }
}