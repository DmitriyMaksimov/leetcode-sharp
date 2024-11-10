using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00009Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00009();
        sut.IsPalindrome(121).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00009();
        sut.IsPalindrome(-121).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00009();
        sut.IsPalindrome(10).Should().BeFalse();
    }
}
