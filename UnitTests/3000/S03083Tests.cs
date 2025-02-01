using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03083Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03083();
        Assert.That(sut.IsSubstringPresent("leetcode"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03083();
        Assert.That(sut.IsSubstringPresent("abcba"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03083();
        Assert.That(sut.IsSubstringPresent("abcd"), Is.False);
    }

    [Test]
    public void BruteForce1()
    {
        var sut = new S03083();
        Assert.That(sut.IsSubstringPresentBruteForce("leetcode"), Is.True);
    }

    [Test]
    public void BruteForce2()
    {
        var sut = new S03083();
        Assert.That(sut.IsSubstringPresentBruteForce("abcba"), Is.True);
    }

    [Test]
    public void BruteForce3()
    {
        var sut = new S03083();
        Assert.That(sut.IsSubstringPresentBruteForce("abcd"), Is.False);
    }
}
