using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00087Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00087();
        Assert.That(sut.IsScramble("great", "rgeat"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00087();
        Assert.That(sut.IsScramble("abcde", "caebd"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00087();
        Assert.That(sut.IsScramble("a", "a"), Is.True);
    }
}
