using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00389Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00389();
        sut.FindTheDifference("abcd", "abcde").Should().Be('e');
    }

    [Test]
    public void T2()
    {
        var sut = new S00389();
        sut.FindTheDifference("", "y").Should().Be('y');
    }
}