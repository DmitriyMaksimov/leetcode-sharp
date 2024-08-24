using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00564Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00564();
        sut.NearestPalindromic("123").Should().Be("121");
    }

    [Test]
    public void T2()
    {
        var sut = new S00564();
        sut.NearestPalindromic("1").Should().Be("0");
    }
}
