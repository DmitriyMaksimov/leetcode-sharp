using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03083Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03083();
        sut.IsSubstringPresent("leetcode").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03083();
        sut.IsSubstringPresent("abcba").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S03083();
        sut.IsSubstringPresent("abcd").Should().BeFalse();
    }

    [Test]
    public void BruteForce1()
    {
        var sut = new S03083();
        sut.IsSubstringPresentBruteForce("leetcode").Should().BeTrue();
    }

    [Test]
    public void BruteForce2()
    {
        var sut = new S03083();
        sut.IsSubstringPresentBruteForce("abcba").Should().BeTrue();
    }

    [Test]
    public void BruteForce3()
    {
        var sut = new S03083();
        sut.IsSubstringPresentBruteForce("abcd").Should().BeFalse();
    }
}