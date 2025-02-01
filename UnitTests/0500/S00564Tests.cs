using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00564Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00564();
        Assert.That(sut.NearestPalindromic("123"), Is.EqualTo("121"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00564();
        Assert.That(sut.NearestPalindromic("1"), Is.EqualTo("0"));
    }
}
