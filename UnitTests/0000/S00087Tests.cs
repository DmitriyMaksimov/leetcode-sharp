using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00087Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00087();
        sut.IsScramble("great", "rgeat").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00087();
        sut.IsScramble("abcde", "caebd").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00087();
        sut.IsScramble("a", "a").Should().BeTrue();
    }
}