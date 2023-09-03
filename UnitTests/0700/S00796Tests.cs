using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00796Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00796();
        sut.RotateString("abcde", "cdeab").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00796();
        sut.RotateString("abcde", "abced").Should().BeFalse();
    }
}