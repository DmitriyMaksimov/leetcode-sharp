using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00389Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00389();
        Assert.That(sut.FindTheDifference("abcd", "abcde"), Is.EqualTo('e'));
    }

    [Test]
    public void T2()
    {
        var sut = new S00389();
        Assert.That(sut.FindTheDifference("", "y"), Is.EqualTo('y'));
    }
}