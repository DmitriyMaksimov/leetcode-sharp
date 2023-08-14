using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00125Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00125();
        sut.IsPalindrome("A man, a plan, a canal: Panama").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00125();
        sut.IsPalindrome("race a car").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00125();
        sut.IsPalindrome(" ").Should().BeTrue();
    }

}